using Helper.DataBase;
using Helper.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Helper.Forms
{
	public partial class WorkPriceForm : Form
	{
		List<WorkPrice> workPrices = new();
		public WorkPriceForm()
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
					var titles = db.WorkTitles.Select(w => w.Name).ToList();
					workPrices.Clear();
					foreach (var title in titles)
					{
						WorkPrice? item = db.WorkPrices.Include(w => w.WorkTitle!.WorkType).OrderBy(w => w.DateTime).LastOrDefault(w => w.WorkTitle!.Name == title);
						if (item != null)
						{
							workPrices.Add(item);
						}
					}
					ShowData(workPrices.OrderBy(w => w.WorkTitle?.WorkType?.Name).ThenBy(w => w.WorkTitle?.Name).ToList());
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
		}

		private void ShowData(List<WorkPrice> dataList)
		{
			DataTable dataTable = new();
			dataTable.Columns.Add("Id");
			dataTable.Columns.Add("Вид работы");
			dataTable.Columns.Add("Наименование работы");
			dataTable.Columns.Add("Единица измерения");
			dataTable.Columns.Add("Цена за единицу (руб.)");
			foreach (WorkPrice item in dataList)
			{
				dataTable.Rows.Add(item.Id, item?.WorkTitle?.WorkType?.Name, item?.WorkTitle?.Name, item?.WorkTitle?.Unit, item?.Price);
			}
			dataGridView1.DataSource = dataTable;
			dataGridView1.Columns["Id"].Visible = false;
			dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
		}


		private void addButton_Click(object sender, EventArgs e)
		{
			WorkTitle workTitle = new();
			WorkPrice workPrice = new();
			WorkTitleForm workTitleForm = new(workTitle, workPrice);
			workTitleForm.Text = "Добавить позицию!";
			if (workTitleForm.ShowDialog() == DialogResult.OK)
			{
				try
				{
					using (Context db = new())
					{
						workPrice.DateTime = DateTime.Now;
						db.WorkPrices.Add(workPrice);
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

		private void editButton_Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count > 0)
			{
				int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
				try
				{
					using (Context db = new())
					{
						WorkPrice workPrice = db.WorkPrices.Include(w => w.WorkTitle).Single(w => w.Id == id);
						double flagPrice = workPrice.Price;
						WorkTitleForm workTitleForm = new(workPrice.WorkTitle!, workPrice);
						workTitleForm.Text = "Изменить позицию!";
						if (workTitleForm.ShowDialog() == DialogResult.OK)
						{
							if (flagPrice != workPrice.Price)
							{
								workPrice.Id = 0;
								workPrice.DateTime = DateTime.Now;
								db.WorkPrices.Add(workPrice);
							}
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

		private void updateButton_Click(object sender, EventArgs e)
		{
			searchTitle.Text = null;
			LoadData();
		}

		private void archiveButton_Click(object sender, EventArgs e)
		{
			ArchivePriceForm archivePriceForm = new();
			archivePriceForm.WindowState = FormWindowState.Maximized;
			archivePriceForm.Show();
		}

		private void searchTitle_TextChanged(object sender, EventArgs e)
		{
			string line = searchTitle.Text.ToLower();
			var filterWorkPrices = workPrices.Where(w => w.Print.ToLower().Contains(line)).ToList();
			ShowData(filterWorkPrices);
		}
	}
}
