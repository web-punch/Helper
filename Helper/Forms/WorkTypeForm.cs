using Helper.Models;

namespace Helper.Forms
{
	public partial class WorkTypeForm : Form
	{
		WorkType WorkType { get; set; }
		public WorkTypeForm(WorkType workType)
		{
			InitializeComponent();
			WorkType = workType;
			FillField();
		}
		private void FillModel()
		{
			WorkType.Name = inputType.Text;
		}
		private void FillField()
		{
			inputType.Text = WorkType.Name;
		}

		private void okButton_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(inputType.Text))
			{
				errorLabel.Text = "Заполните поле!";
				errorLabel.Visible = true;
			}
			else
			{
				DialogResult = DialogResult.OK;
				FillModel();
				Close();
			}
		}

		private void cuncelButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void inputType_TextChanged(object sender, EventArgs e)
		{
			errorLabel.Visible = false;
		}
	}
}
