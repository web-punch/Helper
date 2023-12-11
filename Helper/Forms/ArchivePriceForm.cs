using Helper.DataBase;
using Helper.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Helper.Forms
{
	public partial class ArchivePriceForm : Form
	{
		List<WorkPrice> workPrices = new();
		public ArchivePriceForm()
		{
			InitializeComponent();
			LoadData();
		}
		private void LoadData()
		{
			try
			{
				using (Context db = new())
				{
					workPrices.Clear();
					workPrices = db.WorkPrices.Include(w => w.WorkTitle!.WorkType).OrderBy(w => w.WorkTitle!.WorkType!.Name).ThenBy(w => w.WorkTitle!.Name).ToList();
					LoadDataGrid(workPrices);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
		}
		private void LoadDataGrid(List<WorkPrice> dataList)
		{
			DataTable dataTable = new();
			dataTable.Columns.Add("Id");
			dataTable.Columns.Add("Вид работы");
			dataTable.Columns.Add("Наименование работы");
			dataTable.Columns.Add("Единица измерения");
			dataTable.Columns.Add("Цена за единицу (руб.)");
			dataTable.Columns.Add("Дата добавления");
			foreach (WorkPrice item in dataList)
			{
				dataTable.Rows.Add(item.Id, item?.WorkTitle?.WorkType?.Name, item?.WorkTitle?.Name, item?.WorkTitle?.Unit, item?.Price, item?.DateTime);
			}
			dataGridView1.DataSource = dataTable;
			dataGridView1.Columns["Id"].Visible = false;
			dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
		}

		private void deleteButton_Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count > 0)
			{
				int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
				if (MessageBox.Show("Удалить выбранную запись?", "Подтвердить удаление!",
					MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
				{
					try
					{
						using (Context db = new())
						{
							WorkPrice workPrice = db.WorkPrices.Single(w => w.Id == id);
							WorkTitle workTitle = db.WorkTitles.Single(w => w.Id == workPrice.WorkTitleId);
							db.WorkPrices.Remove(workPrice);
							db.SaveChanges();
							if (!db.WorkPrices.Any(w => w.WorkTitle == workTitle))
							{
								db.WorkTitles.Remove(workTitle);
								db.SaveChanges();
							}
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
		}

		private void searchTitle_TextChanged(object sender, EventArgs e)
		{
			string line = searchTitle.Text.ToLower();
			var filterWorkPrices = workPrices.Where(w => w.Print.ToLower().Contains(line)).ToList();
			LoadDataGrid(filterWorkPrices);
		}

		private void updateButton_Click(object sender, EventArgs e)
		{
			searchTitle.Text = null;
			LoadData();
		}
	}
}
