namespace Helper.Forms
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void priceButton_Click(object sender, EventArgs e)
		{
			WorkPriceForm workPriceForm = new();
			workPriceForm.WindowState = FormWindowState.Maximized;
			workPriceForm.Show();
		}

		private void workButton_Click(object sender, EventArgs e)
		{
			WorksForm worksForm = new();
			worksForm.Show();
		}
	}
}