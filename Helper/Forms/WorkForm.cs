using Helper.DataBase;
using Helper.Models;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.Data;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace Helper.Forms
{
	public partial class WorkForm : Form
	{
		List<WorkTitle> workTitles = new();
		List<Work> works = new();
		Work Work { get; set; }
		public WorkForm(Work work)
		{
			InitializeComponent();
			LoadTypeList();
			Work = work;
			FillField();
			LoadDataGrid();
		}

		//
		// Метод отображает данные в ListBox
		//
		private void ShowListBox(ListBox listBox, IEnumerable<object> list)
		{
			listBox.ValueMember = "Id";
			listBox.DisplayMember = "Name";
			listBox.DataSource = list;
		}

		//
		// Загрузка списка видов работ
		//
		private void LoadTypeList()
		{
			try
			{
				using (Context db = new())
				{
					var typeList = db.WorkTypes.OrderBy(w => w.Name).ToList();
					ShowListBox(typeListBox, typeList);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
		}

		//
		// Событие при выборе элемента списка видов работ (typeListBox)
		//
		private void typeListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (typeListBox.SelectedItem != null)
			{
				int id = Convert.ToInt32(typeListBox.SelectedValue);
				try
				{
					using (Context db = new())
					{
						workTitles = db.WorkTitles.Where(w => w.WorkTypeId == id).OrderBy(w => w.Name).ToList();
						ShowListBox(titleListBox, workTitles);
						unitLabel.Visible = titleListBox.Items.Count != 0;
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
					return;
				}
			}
		}

		//
		// Заполняем свойства модели данными из формы
		//
		private void FillModel()
		{
			Work.DateTime = dateTimePicker1.Value;
			Work.Address = inputAddress.Text;
			Work.Amount = Convert.ToDouble(inputAmount.Value);
			if (Work.Id == 0)
			{
				try
				{
					using (Context db = new())
					{
						Work.WorkPriceId = db.WorkPrices.OrderBy(w => w.DateTime).LastOrDefault(w => w.WorkTitleId == Convert.ToInt32(titleListBox.SelectedValue))!.Id;
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
					return;
				}
			}
		}

		//
		// Заполнение поля формы данными из модели
		//
		private void FillField()
		{
			dateTimePicker1.Value = Work.DateTime;
			if (Work.Id != 0)
			{
				inputAddress.Text = Work.Address;
				typeListBox.SelectedValue = Work!.WorkPrice!.WorkTitle!.WorkTypeId;
				typeListBox.SelectedIndexChanged += typeListBox_SelectedIndexChanged!;
				titleListBox.SelectedValue = Work.WorkPrice.WorkTitleId;
				inputAmount.Value = Convert.ToDecimal(Work?.Amount);
			}
		}
		//
		// Загрузка данных в dataGridView1
		//
		private void LoadDataGrid()
		{
			try
			{
				using (Context db = new())
				{
					works = db.Works.Include(w => w.WorkPrice!.WorkTitle!.WorkType)
						.Where(w => w.DateTime == dateTimePicker1.Value && w.Address == inputAddress.Text)
						.OrderBy(w => w.WorkPrice!.WorkTitle!.WorkType!.Name)
						.ToList();
					DataTable dataTable = new();
					dataTable.Columns.Add("Id");
					dataTable.Columns.Add("Вид работы");
					dataTable.Columns.Add("Наименование работы");
					dataTable.Columns.Add("Ед. изм.");
					dataTable.Columns.Add("Цена за ед.");
					dataTable.Columns.Add("Объём");
					dataTable.Columns.Add("Стоимость");
					double finalSumWorks = 0;
					foreach (var work in works)
					{
						double costWork = work.WorkPrice!.Price * work.Amount;
						finalSumWorks += costWork;
						dataTable.Rows.Add(work.Id, work.WorkPrice.WorkTitle!.WorkType!.Name, work.WorkPrice.WorkTitle.Name,
							work.WorkPrice.WorkTitle.Unit, work.WorkPrice.Price, work.Amount, costWork);
					}
					dataGridView1.DataSource = dataTable;
					dataGridView1.Columns["Id"].Visible = false;
					dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
					finalSum.Text = finalSumWorks.ToString("C2");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
		}

		//
		// Событие при нажатии кнопку "Добавить" (addButton)
		//
		private void addButton_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(inputAddress.Text))
			{
				errorAddress.Text = "Заполните поле!";
				errorAddress.Visible = true;
			}
			else
			{
				Work = new();
				ActivateAddingAndEditing();
			}
		}

		//
		// Событие при нажатии кнопку "Изменить" (editButton)
		//
		private void editButton_Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count > 0)
			{
				int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
				try
				{
					using (Context db = new())
					{
						Work = db.Works.Include(w => w.WorkPrice!.WorkTitle!.WorkType).Single(w => w.Id == id);
						FillField();
						ActivateAddingAndEditing();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
					return;
				}
			}
		}

		//
		// Событие при нажатии кнопку "Удалить" (deleteButton)
		//
		private void deleteButton_Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count > 0)
			{
				int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
				if (MessageBox.Show("Удалить выбранную запись?", "Подтвердите удаление!",
					MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
				{
					try
					{
						using (Context db = new())
						{
							Work = db.Works.Single(w => w.Id == id);
							db.Works.Remove(Work);
							db.SaveChanges();
							LoadDataGrid();
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message);
						return;
					}
				}
			}
		}

		//
		// Событие при нажатии кнопку "ОК" (okButton)
		//
		private void okButton_Click(object sender, EventArgs e)
		{
			if (titleListBox.SelectedItem == null || inputAmount.Value == 0)
			{
				errorTitle.Visible = titleListBox.SelectedItem == null;
				errorAmount.Visible = inputAmount.Value == 0;
			}
			else
			{
				FillModel();
				try
				{
					using (Context db = new())
					{
						if (!db.Works.Contains(Work))
						{
							db.Works.Add(Work);
						}
						else
						{
							db.Works.Update(Work);
						}
						db.SaveChanges();
						LoadDataGrid();
						DeactivateAddingAndEditing();
					}
				}
				catch (DbUpdateException ex)
				{
					if (ex.InnerException!.Message.Contains("UNIQUE constraint failed"))
					{
						MessageBox.Show("Запись с таким наименованием работ уже существует!", "Ошибка!",
							MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
					return;
				}
			}
		}

		//
		// Событие при нажатии кнопку "Отмена" (cancelButton)
		//
		private void cancelButton_Click(object sender, EventArgs e)
		{
			DeactivateAddingAndEditing();
		}

		//
		// Метод активирует окна для добавления и изменения данных
		//
		private void ActivateAddingAndEditing()
		{
			if (Work.Id != 0)
			{
				groupBox1.Enabled = false;
				tableLayoutPanel4.Enabled = false;
				plusButton.Visible = true;
				minusButton.Visible = true;
			}
			tableLayoutPanel3.Enabled = true;
			tableLayoutPanel2.Enabled = false;
		}

		//
		// Метод обратный методу ActivateAddingAndEditing()
		//
		private void DeactivateAddingAndEditing()
		{
			tableLayoutPanel3.Enabled = false;
			plusButton.Visible = false;
			minusButton.Visible = false;
			tableLayoutPanel2.Enabled = true;
			groupBox1.Enabled = true;
			tableLayoutPanel4.Enabled = true;
		}

		//
		// Метод отключает управление полями даты и адреса
		//
		public void DeactivationDateAndAddress()
		{
			dateTimePicker1.Enabled = false;
			inputAddress.Enabled = false;
		}

		//
		// Событие при изменение текста в поле адреса (inputAddress)
		//
		private void inputAddress_TextChanged(object sender, EventArgs e)
		{
			errorAddress.Visible = false;
		}

		//
		// Событие при выборе элемента списка наименований работ (titleListBox)
		//
		private void titleListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			int id = Convert.ToInt32(titleListBox.SelectedValue);
			if (id != 0)
			{
				unitLabel.Text = workTitles.Single(w => w.Id == id).Unit;
				inputAmount.Value = 0;
				errorTitle.Visible = false;
			}
		}

		//
		// Событие при изменение текста в поле поиска наименований работ (searchTitle)
		//
		private void searchTitle_TextChanged(object sender, EventArgs e)
		{
			string line = searchTitle.Text.ToLower();
			var filterWorkTitles = workTitles.Where(w => w.Name!.ToLower().Contains(line)).ToList();
			ShowListBox(titleListBox, filterWorkTitles);
			unitLabel.Visible = titleListBox.Items.Count != 0;
		}

		private void inputAmount_Enter(object sender, EventArgs e)
		{
			errorAmount.Visible = false;
		}

		//
		// Событие при нажатии на кнопку "Сохранить в Excel" (saveExcelButton)
		//
		private void saveExcelButton_Click(object sender, EventArgs e)
		{
			if (dataGridView1.Rows.Count > 0)
			{
				try
				{
					ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
					using (ExcelPackage package = new()) // Создаём новый пакет ExcelPackage
					{
						ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Лист1"); // Создаём рабочий лист
						worksheet.Cells[1, 2, 1, 6].Merge = true; // Объединяем ячейки в первой строке со второго по шестой столбец
						worksheet.SetValue(1, 2, $"{inputAddress.Text}_{dateTimePicker1.Value:dd.MM.yyyy}"); // установить значение ячейки (строка, столбец, значение)
						worksheet.Cells[1, 2].Style.Font.Size = 14; // размер шрифта
						worksheet.Cells[1, 2].Style.Font.Bold = true; // жирный шрифт
						worksheet.Cells[1, 2].Style.Font.Italic = true; // шрифт курсивом
						worksheet.Cells[1, 2].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center; // содержимое ячейки по центру
						worksheet.SetValue(3, 2, "Наименование работ");
						worksheet.SetValue(3, 3, "Ед.изм.");
						worksheet.SetValue(3, 4, "Цена за ед.");
						worksheet.SetValue(3, 5, "Объём");
						worksheet.SetValue(3, 6, "Стоимость");
						worksheet.Cells[3, 2, 3, 6].Style.Fill.PatternType = ExcelFillStyle.Solid; // тип заливки сплошной
						worksheet.Cells[3, 2, 3, 6].Style.Fill.BackgroundColor.SetColor(Color.Yellow); // цвет заливки
						worksheet.Cells[3, 2, 3, 6].Style.Font.Bold = true;
						worksheet.Cells[3, 2, 3, 6].Style.Font.Italic = true;
						worksheet.Cells[3, 2, 3, 6].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
						worksheet.Column(3).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center; // во всех ячейках третей колонки содержимое по центру
						List<string> totalSumCell = new();
						int line = 4;
						foreach (var type in works.Select(w => w.WorkPrice!.WorkTitle!.WorkType).Distinct().OrderBy(w => w!.Name))
						{
							worksheet.Cells[line, 2, line, 5].Merge = true;
							worksheet.Cells[line, 2].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
							worksheet.SetValue(line, 2, type!.Name);
							worksheet.Cells[line, 2, line, 6].Style.Fill.PatternType = ExcelFillStyle.Solid;
							worksheet.Cells[line, 2, line, 6].Style.Fill.BackgroundColor.SetColor(0, 170, 170, 170);
							var sumCell = worksheet.Cells[line, 6].Address; // получаем адрес ячейки
							totalSumCell.Add(sumCell);
							line++;
							var startOfRange = worksheet.Cells[line, 6].Address;
							foreach (var work in works.Where(w => w.WorkPrice!.WorkTitle!.WorkType == type))
							{
								worksheet.SetValue(line, 2, work.WorkPrice!.WorkTitle!.Name);
								worksheet.SetValue(line, 3, work.WorkPrice.WorkTitle!.Unit);
								worksheet.SetValue(line, 4, work.WorkPrice!.Price);
								worksheet.SetValue(line, 5, work.Amount);
								worksheet.Cells[line, 6].Formula = $"{worksheet.Cells[line, 4].Address}*{worksheet.Cells[line, 5].Address}"; // вставляем формулу произведения в ячейку
								line++;
							}
							var endOfRange = worksheet.Cells[line - 1, 6].Address;
							worksheet.Cells[sumCell].Formula = $"SUM({startOfRange}:{endOfRange})"; // вставляем формулу суммы в ячейку
						}
						worksheet.SetValue(line, 5, "Итого:");
						worksheet.Cells[line, 6].Formula = string.Join("+", totalSumCell); // создаем из списка с адресами ячеек строку вида (F4+F6+F8......) и вставляем её в виде формулы в ячейку
						worksheet.Cells[line, 5, line, 6].Style.Fill.PatternType = ExcelFillStyle.Solid;
						worksheet.Cells[line, 5, line, 6].Style.Fill.BackgroundColor.SetColor(Color.Yellow);
						worksheet.Cells[line, 5, line, 6].Style.Font.Bold = true;
						worksheet.Cells[line, 5, line, 6].Style.Font.Italic = true;
						worksheet.Cells[line, 5].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
						worksheet.Cells[3, 2, line, 6].AutoFitColumns(); //Автоподбор столбцов Уместить весь текст в ячейки
						worksheet.Cells[3, 2, line, 6].Style.Border.Top.Style = ExcelBorderStyle.Medium; // толщина верхней линии ячейки
						worksheet.Cells[3, 2, line, 6].Style.Border.Bottom.Style = ExcelBorderStyle.Medium; // нижней
						worksheet.Cells[3, 2, line, 6].Style.Border.Right.Style = ExcelBorderStyle.Medium; // правой
						worksheet.Cells[3, 2, line, 6].Style.Border.Left.Style = ExcelBorderStyle.Medium; // левой
						worksheet.Cells[line, 2, line, 4].Delete(eShiftTypeDelete.Up); // удалить ячейки со сдвигом вверх

						saveFileDialog1.Filter = "Файл Excel|*.xlsx"; // тип файла в диалоговом окне сохранения файла
						saveFileDialog1.FileName = $"{inputAddress.Text}_{dateTimePicker1.Value:dd.MM.yyyy}.xlsx"; // имя файла в диалоговом окне сохранения файла
						if (saveFileDialog1.ShowDialog() == DialogResult.OK)
						{
							package.SaveAs(new FileInfo(saveFileDialog1.FileName));
						}
					}
				}
				catch (InvalidOperationException ex)
				{
					if (ex.InnerException!.Message.Contains("Error overwriting file"))
					{
						MessageBox.Show("Заменяемый файл используется другим процессом, закройте его и повторите действие!", "Ошибка перезаписи файла",
							MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
					return;
				}
			}
		}

		//
		// Событие при нажатии на кнопку "+" (plusButton)
		//
		private void plusButton_Click(object sender, EventArgs e)
		{
			ChangeInputAmountForm changeInputAmountForm = new(Work.Amount, unitLabel.Text, true);
			changeInputAmountForm.Text = "Увеличить на";
			if(changeInputAmountForm.ShowDialog() == DialogResult.OK)
			{
				Work.Amount = changeInputAmountForm.Amount;
				FillField();
			}
		}

		//
		// Событие при нажатии на кнопку "-" (minusButton)
		//
		private void minusButton_Click(object sender, EventArgs e)
		{
			ChangeInputAmountForm changeInputAmountForm = new(Work.Amount, unitLabel.Text, false);
			changeInputAmountForm.Text = "Уменьшить на";
			if (changeInputAmountForm.ShowDialog() == DialogResult.OK)
			{
				Work.Amount = changeInputAmountForm.Amount < 0 ? 0 : changeInputAmountForm.Amount;
				FillField();
			}
		}
	}
}

