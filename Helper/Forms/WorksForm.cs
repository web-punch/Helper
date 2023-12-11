using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Helper.Models;
using Helper.DataBase;
using Microsoft.EntityFrameworkCore;

namespace Helper.Forms
{
	public partial class WorksForm : Form
	{
		List<Work> works = new();
		public WorksForm()
		{
			InitializeComponent();
			LoadData();
		}

		//
		// Метод загружает список работ из БД, удаляя дубликаты из коллекции. Настройка сравнения дубликатов в Models.Work.cs
		//
		private void LoadData()
		{
			try
			{
				using (Context db = new())
				{
					works.Clear();
					works = db.Works.OrderBy(w => w.DateTime).ThenBy(w => w.Address).ToList().Distinct().ToList();
					ShowData(works);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
		}

		//
		//  Метод отображает данные в DataGrid
		//
		private void ShowData(List<Work> dataList)
		{
			DataTable dataTable = new();
			dataTable.Columns.Add("Id");
			dataTable.Columns.Add("Дата");
			dataTable.Columns.Add("Объект");
			foreach (Work item in dataList)
			{
				dataTable.Rows.Add(item.Id, item.DateTime.ToShortDateString(), item.Address);
			}
			dataGridView1.DataSource = dataTable;
			dataGridView1.Columns["Id"].Visible = false;
		}

		//
		// Событие при нажатии кнопки "Добавить"
		//
		private void addButton_Click(object sender, EventArgs e)
		{
			Work work = new();
			WorkForm workForm = new(work);
			workForm.WindowState = FormWindowState.Maximized;
			workForm.Show();
		}

		//
		// Событие при нажатии кнопки "Просмотр"
		//
		private void viewButton_Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count > 0)
			{
				int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
				try
				{
					using (Context db = new())
					{
						Work work = db.Works.Include(w => w.WorkPrice!.WorkTitle!.WorkType).Single(w => w.Id == id);
						WorkForm workForm = new(work);
						workForm.WindowState = FormWindowState.Maximized;
						workForm.DeactivationDateAndAddress();
						workForm.Show();
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
		// Событие при нажатии кнопки "Удалить"
		//
		private void deleteButton_Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count > 0)
			{
				int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
				try
				{
					using (Context db = new())
					{
						Work work = db.Works.Single(w => w.Id == id);
						if (MessageBox.Show($"Удалить все записи {work.Address} за {work.DateTime.ToShortDateString()}?",
							"Подтвердите удаление!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
						{
							var deleteWorks = db.Works.Where(w => w.DateTime == work.DateTime && w.Address == work.Address).ToList();
							db.Works.RemoveRange(deleteWorks);
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
		// Событие при нажатии кнопки "Обновить"
		//
		private void updateButton_Click(object sender, EventArgs e)
		{
			LoadData();
			searchWorks.Text = "";
		}

		private void searchWorks_TextChanged(object sender, EventArgs e)
		{
			string line = searchWorks.Text.ToLower();
			var filterWorks = works.Where(w => w.Print.ToLower().Contains(line)).OrderBy(w => w.DateTime).ToList();
			ShowData(filterWorks);
		}
	}
}
