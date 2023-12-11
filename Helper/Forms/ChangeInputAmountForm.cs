using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helper.Forms
{
	public partial class ChangeInputAmountForm : Form
	{
		public double Amount { get; set; }
		public bool Flag { get; set; }

		public ChangeInputAmountForm(double amount, string unit, bool flag)
		{
			InitializeComponent();
			Amount = amount;
			unitLabel.Text = unit;
			Flag = flag;
		}

		private void okButton_Click(object sender, EventArgs e)
		{
			if (inputValue.Value > 0)
			{
				try
				{
					if (Flag)
					{
						Amount += Convert.ToDouble(inputValue.Value);
					}
					else
					{
						Amount -= Convert.ToDouble(inputValue.Value);
					}

				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
					return;
				}
				DialogResult = DialogResult.OK;
				Close();
			}
			else
			{
				errorLabel.Text = "Введите значение!";
				errorLabel.Visible = true;
			}
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void inputValue_Enter(object sender, EventArgs e)
		{
			errorLabel.Visible = false;
		}
	}
}
