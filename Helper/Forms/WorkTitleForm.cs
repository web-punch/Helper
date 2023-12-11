using Helper.DataBase;
using Helper.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Helper.Forms
{
	public partial class WorkTitleForm : Form
	{
		List<WorkType> workTypes = new();
		WorkTitle WorkTitle { get; set; }
		WorkPrice WorkPrice { get; set; }
		public WorkTitleForm(WorkTitle workTitle, WorkPrice workPrice)
		{
			InitializeComponent();
			LoadData();
			WorkTitle = workTitle;
			WorkPrice = workPrice;
			FillField();
		}

		//
		// Загрузка видов работ из БД
		//
		private void LoadData()
		{
			try
			{
				using (Context db = new())
				{
					workTypes = db.WorkTypes.OrderBy(w => w.Name).ToList();
					typesListBox.ValueMember = "Id";
					typesListBox.DisplayMember = "Name";
					typesListBox.DataSource = workTypes;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
		}

		//
		// Событие при клике на кнопку "Добавить"
		//
		private void addTypeButton_Click(object sender, EventArgs e)
		{
			WorkType workType = new();
			WorkTypeForm workTypeForm = new(workType);
			workTypeForm.Text = "Добавить вид работы!";
			if (workTypeForm.ShowDialog() == DialogResult.OK)
			{
				try
				{
					using (Context db = new())
					{
						db.WorkTypes.Add(workType);
						db.SaveChanges();
						LoadData();
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
		// Событие при клике на кнопку "Изменить"
		//
		private void editTypeButton_Click(object sender, EventArgs e)
		{
			if (typesListBox.SelectedItems.Count > 0)
			{
				int id = Convert.ToInt32(typesListBox.SelectedValue);
				try
				{
					using (Context db = new())
					{
						WorkType workType = db.WorkTypes.Single(w => w.Id == id);
						WorkTypeForm workTypeForm = new(workType);
						workTypeForm.Text = "Изменить вид работы!";
						if (workTypeForm.ShowDialog() == DialogResult.OK)
						{
							db.SaveChanges();
							LoadData();
						}
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
		// Событие при клике на кнопку "Удалить"
		//
		private void deleteTypeButton_Click(object sender, EventArgs e)
		{
			if (typesListBox.SelectedItems.Count > 0)
			{
				int id = Convert.ToInt32(typesListBox.SelectedValue);
				if (MessageBox.Show("Удалить выбранную запись?", "Подтвердить удаление!",
					MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
				{
					try
					{
						using (Context db = new())
						{
							WorkType workType = db.WorkTypes.Single(w => w.Id == id);
							db.WorkTypes.Remove(workType);
							db.SaveChanges();
							LoadData();
						}
					}
					catch (DbUpdateException ex) // Обработка исключения с ограничением по внешнему ключу
					{
						if (ex.InnerException!.Message.Contains("FOREIGN KEY constraint failed"))
						{
							MessageBox.Show("Выбранный вид работ связан с позициями из прайса!", "Ошибка удаления!",
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
		}

		//
		// Эаполнить модель
		//
		private void FillModel()
		{
			try
			{
				using (Context db = new())
				{
					string rbText = "";
					foreach (RadioButton rb in unitsGroupBox.Controls)
					{
						if (rb.Checked)
						{
							rbText = rb.Text;
							break;
						}
					}
					WorkTitle!.WorkTypeId = Convert.ToInt32(typesListBox.SelectedValue);
					WorkTitle.Name = inputTitle.Text;
					WorkTitle.Unit = rbText;
					if (WorkTitle.Id != 0)
					{
						db.SaveChanges();
					}
					else
					{
						WorkTitle.Id = db.WorkTitles.Any(w => w.Name == inputTitle.Text && w.WorkTypeId == Convert.ToInt32(typesListBox.SelectedValue) && w.Unit == rbText) ? db.WorkTitles.Single(w => w.Name == inputTitle.Text && w.WorkTypeId == Convert.ToInt32(typesListBox.SelectedValue) && w.Unit == rbText)!.Id : 0;
						if (WorkTitle.Id == 0)
						{
							db.WorkTitles.Add(WorkTitle);
							db.SaveChanges();
						}
					}
					WorkPrice.Price = Convert.ToDouble(inputPrice.Value);
					//WorkPrice.DateTime = DateTime.Now;
					WorkPrice.WorkTitleId = WorkTitle.Id;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
		}

		//
		// Заполнить поля формы
		//
		private void FillField()
		{
			typesListBox.SelectedValue = WorkTitle.WorkTypeId;
			inputTitle.Text = WorkTitle.Name;
			foreach (RadioButton rb in unitsGroupBox.Controls)
			{
				if (rb.Text == WorkTitle.Unit)
				{
					rb.Checked = true;
				}
			}
			inputPrice.Value = Convert.ToDecimal(WorkPrice.Price);
		}

		//
		// Событие при клике на кнопку "OK"
		//
		private void okButton_Click(object sender, EventArgs e)
		{
			errorTypeLabel.Visible = typesListBox.SelectedValue == null;
			errorTitleLabel.Visible = string.IsNullOrWhiteSpace(inputTitle.Text);
			if (typesListBox.SelectedValue != null && !string.IsNullOrWhiteSpace(inputTitle.Text))
			{
				DialogResult = DialogResult.OK;
				FillModel();
				Close();
			}
		}
		//
		// Событие при клике на кнопку "Отмена"
		//
		private void cancelButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		//
		// Событие при изменении текста в строке поиска
		//
		private void searchType_TextChanged(object sender, EventArgs e)
		{
			string line = searchType.Text.ToLower();
			var filterWorkTypes = workTypes.Where(w => w.Name!.ToLower().Contains(line)).ToList();
			typesListBox.ValueMember = "Id";
			typesListBox.DisplayMember = "Name";
			typesListBox.DataSource = filterWorkTypes;
		}

		//
		// Событие при выборе элемента списка видов работы
		//
		private void typesListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			errorTypeLabel.Visible = false;
		}

		//
		// Событие при изменении текста в строке наименование работы
		//
		private void inputTitle_TextChanged(object sender, EventArgs e)
		{
			errorTitleLabel.Visible = false;
		}
	}
}
