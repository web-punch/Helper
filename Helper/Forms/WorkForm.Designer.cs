namespace Helper.Forms
{
	partial class WorkForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkForm));
			deleteButton = new Button();
			tableLayoutPanel1 = new TableLayoutPanel();
			tableLayoutPanel2 = new TableLayoutPanel();
			saveExcelButton = new Button();
			panel1 = new Panel();
			dateTimePicker1 = new DateTimePicker();
			label2 = new Label();
			finalSum = new TextBox();
			editButton = new Button();
			addButton = new Button();
			errorAddress = new Label();
			label1 = new Label();
			inputAddress = new TextBox();
			dataGridView1 = new DataGridView();
			tableLayoutPanel3 = new TableLayoutPanel();
			panel2 = new Panel();
			minusButton = new Button();
			plusButton = new Button();
			errorAmount = new Label();
			unitLabel = new Label();
			inputAmount = new NumericUpDown();
			label5 = new Label();
			cancelButton = new Button();
			okButton = new Button();
			groupBox1 = new GroupBox();
			typeListBox = new ListBox();
			tableLayoutPanel4 = new TableLayoutPanel();
			errorTitle = new Label();
			panel3 = new Panel();
			label6 = new Label();
			searchTitle = new TextBox();
			label4 = new Label();
			titleListBox = new ListBox();
			saveFileDialog1 = new SaveFileDialog();
			tableLayoutPanel1.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			tableLayoutPanel3.SuspendLayout();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)inputAmount).BeginInit();
			groupBox1.SuspendLayout();
			tableLayoutPanel4.SuspendLayout();
			panel3.SuspendLayout();
			SuspendLayout();
			// 
			// deleteButton
			// 
			deleteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			deleteButton.Image = (Image)resources.GetObject("deleteButton.Image");
			deleteButton.Location = new Point(315, 82);
			deleteButton.Margin = new Padding(5, 6, 5, 6);
			deleteButton.Name = "deleteButton";
			deleteButton.Size = new Size(145, 44);
			deleteButton.TabIndex = 9;
			deleteButton.Text = "Удалить";
			deleteButton.TextAlign = ContentAlignment.MiddleRight;
			deleteButton.TextImageRelation = TextImageRelation.ImageBeforeText;
			deleteButton.UseVisualStyleBackColor = true;
			deleteButton.Click += deleteButton_Click;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			tableLayoutPanel1.ColumnCount = 2;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
			tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
			tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 0);
			tableLayoutPanel1.Location = new Point(20, 23);
			tableLayoutPanel1.Margin = new Padding(5, 6, 5, 6);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 1;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Size = new Size(2145, 1370);
			tableLayoutPanel1.TabIndex = 10;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			tableLayoutPanel2.ColumnCount = 1;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel2.Controls.Add(saveExcelButton, 0, 2);
			tableLayoutPanel2.Controls.Add(panel1, 0, 0);
			tableLayoutPanel2.Controls.Add(dataGridView1, 0, 1);
			tableLayoutPanel2.Location = new Point(5, 6);
			tableLayoutPanel2.Margin = new Padding(5, 6, 5, 6);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 3;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 144F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 77F));
			tableLayoutPanel2.Size = new Size(1277, 1358);
			tableLayoutPanel2.TabIndex = 0;
			// 
			// saveExcelButton
			// 
			saveExcelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			saveExcelButton.AutoSize = true;
			saveExcelButton.Image = (Image)resources.GetObject("saveExcelButton.Image");
			saveExcelButton.Location = new Point(995, 1287);
			saveExcelButton.Margin = new Padding(5, 6, 5, 6);
			saveExcelButton.Name = "saveExcelButton";
			saveExcelButton.Size = new Size(277, 65);
			saveExcelButton.TabIndex = 0;
			saveExcelButton.Text = "Сохранить в Excel";
			saveExcelButton.TextAlign = ContentAlignment.MiddleRight;
			saveExcelButton.TextImageRelation = TextImageRelation.ImageBeforeText;
			saveExcelButton.UseVisualStyleBackColor = true;
			saveExcelButton.Click += saveExcelButton_Click;
			// 
			// panel1
			// 
			panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			panel1.Controls.Add(dateTimePicker1);
			panel1.Controls.Add(label2);
			panel1.Controls.Add(finalSum);
			panel1.Controls.Add(deleteButton);
			panel1.Controls.Add(editButton);
			panel1.Controls.Add(addButton);
			panel1.Controls.Add(errorAddress);
			panel1.Controls.Add(label1);
			panel1.Controls.Add(inputAddress);
			panel1.Location = new Point(5, 6);
			panel1.Margin = new Padding(5, 6, 5, 6);
			panel1.Name = "panel1";
			panel1.Size = new Size(1267, 132);
			panel1.TabIndex = 1;
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.Location = new Point(5, 6);
			dateTimePicker1.Margin = new Padding(5, 6, 5, 6);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(331, 31);
			dateTimePicker1.TabIndex = 12;
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			label2.AutoSize = true;
			label2.Location = new Point(968, 52);
			label2.Margin = new Padding(5, 0, 5, 0);
			label2.Name = "label2";
			label2.Size = new Size(65, 25);
			label2.TabIndex = 11;
			label2.Text = "Итого:";
			// 
			// finalSum
			// 
			finalSum.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			finalSum.Location = new Point(1043, 49);
			finalSum.Margin = new Padding(5, 6, 5, 6);
			finalSum.Name = "finalSum";
			finalSum.ReadOnly = true;
			finalSum.Size = new Size(216, 31);
			finalSum.TabIndex = 10;
			finalSum.TextAlign = HorizontalAlignment.Right;
			// 
			// editButton
			// 
			editButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			editButton.Image = (Image)resources.GetObject("editButton.Image");
			editButton.Location = new Point(160, 82);
			editButton.Margin = new Padding(5, 6, 5, 6);
			editButton.Name = "editButton";
			editButton.Size = new Size(145, 44);
			editButton.TabIndex = 5;
			editButton.Text = "Изменить";
			editButton.TextAlign = ContentAlignment.MiddleRight;
			editButton.TextImageRelation = TextImageRelation.ImageBeforeText;
			editButton.UseVisualStyleBackColor = true;
			editButton.Click += editButton_Click;
			// 
			// addButton
			// 
			addButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			addButton.Image = (Image)resources.GetObject("addButton.Image");
			addButton.Location = new Point(5, 82);
			addButton.Margin = new Padding(5, 6, 5, 6);
			addButton.Name = "addButton";
			addButton.Size = new Size(145, 44);
			addButton.TabIndex = 4;
			addButton.Text = "Добавить";
			addButton.TextAlign = ContentAlignment.MiddleRight;
			addButton.TextImageRelation = TextImageRelation.ImageBeforeText;
			addButton.UseVisualStyleBackColor = true;
			addButton.Click += addButton_Click;
			// 
			// errorAddress
			// 
			errorAddress.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			errorAddress.AutoSize = true;
			errorAddress.ForeColor = Color.Red;
			errorAddress.Location = new Point(478, 51);
			errorAddress.Margin = new Padding(5, 0, 5, 0);
			errorAddress.Name = "errorAddress";
			errorAddress.Size = new Size(78, 25);
			errorAddress.TabIndex = 3;
			errorAddress.Text = "Ошибка";
			errorAddress.Visible = false;
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			label1.AutoSize = true;
			label1.Location = new Point(405, 11);
			label1.Margin = new Padding(5, 0, 5, 0);
			label1.Name = "label1";
			label1.Size = new Size(62, 25);
			label1.TabIndex = 2;
			label1.Text = "Адрес";
			// 
			// inputAddress
			// 
			inputAddress.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			inputAddress.Location = new Point(478, 6);
			inputAddress.Margin = new Padding(5, 6, 5, 6);
			inputAddress.Name = "inputAddress";
			inputAddress.Size = new Size(781, 31);
			inputAddress.TabIndex = 1;
			inputAddress.TextChanged += inputAddress_TextChanged;
			// 
			// dataGridView1
			// 
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.AllowUserToDeleteRows = false;
			dataGridView1.AllowUserToResizeRows = false;
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Dock = DockStyle.Fill;
			dataGridView1.Location = new Point(5, 150);
			dataGridView1.Margin = new Padding(5, 6, 5, 6);
			dataGridView1.MultiSelect = false;
			dataGridView1.Name = "dataGridView1";
			dataGridView1.ReadOnly = true;
			dataGridView1.RowHeadersVisible = false;
			dataGridView1.RowHeadersWidth = 62;
			dataGridView1.RowTemplate.Height = 23;
			dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView1.Size = new Size(1267, 1125);
			dataGridView1.TabIndex = 2;
			// 
			// tableLayoutPanel3
			// 
			tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			tableLayoutPanel3.ColumnCount = 1;
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel3.Controls.Add(panel2, 0, 2);
			tableLayoutPanel3.Controls.Add(groupBox1, 0, 0);
			tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 1);
			tableLayoutPanel3.Enabled = false;
			tableLayoutPanel3.Location = new Point(1292, 6);
			tableLayoutPanel3.Margin = new Padding(5, 6, 5, 6);
			tableLayoutPanel3.Name = "tableLayoutPanel3";
			tableLayoutPanel3.RowCount = 3;
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 115F));
			tableLayoutPanel3.Size = new Size(848, 1358);
			tableLayoutPanel3.TabIndex = 1;
			// 
			// panel2
			// 
			panel2.AutoSize = true;
			panel2.Controls.Add(minusButton);
			panel2.Controls.Add(plusButton);
			panel2.Controls.Add(errorAmount);
			panel2.Controls.Add(unitLabel);
			panel2.Controls.Add(inputAmount);
			panel2.Controls.Add(label5);
			panel2.Controls.Add(cancelButton);
			panel2.Controls.Add(okButton);
			panel2.Dock = DockStyle.Fill;
			panel2.Location = new Point(5, 1248);
			panel2.Margin = new Padding(5, 6, 5, 6);
			panel2.Name = "panel2";
			panel2.Size = new Size(838, 104);
			panel2.TabIndex = 0;
			// 
			// minusButton
			// 
			minusButton.Image = (Image)resources.GetObject("minusButton.Image");
			minusButton.Location = new Point(426, 3);
			minusButton.Name = "minusButton";
			minusButton.Size = new Size(55, 55);
			minusButton.TabIndex = 7;
			minusButton.TextImageRelation = TextImageRelation.ImageBeforeText;
			minusButton.UseVisualStyleBackColor = true;
			minusButton.Visible = false;
			minusButton.Click += minusButton_Click;
			// 
			// plusButton
			// 
			plusButton.Image = (Image)resources.GetObject("plusButton.Image");
			plusButton.Location = new Point(365, 3);
			plusButton.Name = "plusButton";
			plusButton.Size = new Size(55, 55);
			plusButton.TabIndex = 6;
			plusButton.TextImageRelation = TextImageRelation.ImageBeforeText;
			plusButton.UseVisualStyleBackColor = true;
			plusButton.Visible = false;
			plusButton.Click += plusButton_Click;
			// 
			// errorAmount
			// 
			errorAmount.AutoSize = true;
			errorAmount.ForeColor = Color.Red;
			errorAmount.Location = new Point(87, 53);
			errorAmount.Margin = new Padding(8, 10, 8, 10);
			errorAmount.Name = "errorAmount";
			errorAmount.Size = new Size(157, 25);
			errorAmount.TabIndex = 5;
			errorAmount.Text = "Введите значение";
			errorAmount.Visible = false;
			// 
			// unitLabel
			// 
			unitLabel.AutoEllipsis = true;
			unitLabel.AutoSize = true;
			unitLabel.Location = new Point(297, 10);
			unitLabel.Margin = new Padding(5, 0, 5, 0);
			unitLabel.Name = "unitLabel";
			unitLabel.Size = new Size(57, 25);
			unitLabel.TabIndex = 4;
			unitLabel.Text = "ед.из.";
			unitLabel.Visible = false;
			// 
			// inputAmount
			// 
			inputAmount.DecimalPlaces = 3;
			inputAmount.Location = new Point(87, 6);
			inputAmount.Margin = new Padding(5, 6, 5, 6);
			inputAmount.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
			inputAmount.Name = "inputAmount";
			inputAmount.Size = new Size(200, 31);
			inputAmount.TabIndex = 3;
			inputAmount.Enter += inputAmount_Enter;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(10, 10);
			label5.Margin = new Padding(5, 0, 5, 0);
			label5.Name = "label5";
			label5.Size = new Size(69, 25);
			label5.TabIndex = 2;
			label5.Text = "Объём";
			// 
			// cancelButton
			// 
			cancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			cancelButton.Image = (Image)resources.GetObject("cancelButton.Image");
			cancelButton.Location = new Point(688, 54);
			cancelButton.Margin = new Padding(5, 6, 5, 6);
			cancelButton.Name = "cancelButton";
			cancelButton.Size = new Size(145, 44);
			cancelButton.TabIndex = 1;
			cancelButton.Text = "Отмена";
			cancelButton.TextAlign = ContentAlignment.MiddleRight;
			cancelButton.TextImageRelation = TextImageRelation.ImageBeforeText;
			cancelButton.UseVisualStyleBackColor = true;
			cancelButton.Click += cancelButton_Click;
			// 
			// okButton
			// 
			okButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			okButton.Image = (Image)resources.GetObject("okButton.Image");
			okButton.Location = new Point(533, 54);
			okButton.Margin = new Padding(5, 6, 5, 6);
			okButton.Name = "okButton";
			okButton.Size = new Size(145, 44);
			okButton.TabIndex = 0;
			okButton.Text = "OK";
			okButton.TextAlign = ContentAlignment.MiddleRight;
			okButton.TextImageRelation = TextImageRelation.ImageBeforeText;
			okButton.UseVisualStyleBackColor = true;
			okButton.Click += okButton_Click;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(typeListBox);
			groupBox1.Dock = DockStyle.Fill;
			groupBox1.Location = new Point(5, 6);
			groupBox1.Margin = new Padding(5, 6, 5, 6);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new Padding(5, 6, 5, 6);
			groupBox1.Size = new Size(838, 485);
			groupBox1.TabIndex = 1;
			groupBox1.TabStop = false;
			groupBox1.Text = "Вид работы";
			// 
			// typeListBox
			// 
			typeListBox.Dock = DockStyle.Fill;
			typeListBox.FormattingEnabled = true;
			typeListBox.ItemHeight = 25;
			typeListBox.Location = new Point(5, 30);
			typeListBox.Margin = new Padding(5, 6, 5, 6);
			typeListBox.Name = "typeListBox";
			typeListBox.Size = new Size(828, 449);
			typeListBox.TabIndex = 0;
			typeListBox.SelectedIndexChanged += typeListBox_SelectedIndexChanged;
			// 
			// tableLayoutPanel4
			// 
			tableLayoutPanel4.ColumnCount = 1;
			tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel4.Controls.Add(errorTitle, 0, 2);
			tableLayoutPanel4.Controls.Add(panel3, 0, 0);
			tableLayoutPanel4.Controls.Add(titleListBox, 0, 1);
			tableLayoutPanel4.Dock = DockStyle.Fill;
			tableLayoutPanel4.Location = new Point(5, 503);
			tableLayoutPanel4.Margin = new Padding(5, 6, 5, 6);
			tableLayoutPanel4.Name = "tableLayoutPanel4";
			tableLayoutPanel4.RowCount = 3;
			tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 67F));
			tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
			tableLayoutPanel4.Size = new Size(838, 733);
			tableLayoutPanel4.TabIndex = 2;
			// 
			// errorTitle
			// 
			errorTitle.AutoSize = true;
			errorTitle.ForeColor = Color.Red;
			errorTitle.Location = new Point(8, 695);
			errorTitle.Margin = new Padding(8, 10, 8, 10);
			errorTitle.Name = "errorTitle";
			errorTitle.Size = new Size(258, 25);
			errorTitle.TabIndex = 0;
			errorTitle.Text = "Выберите позицию из списка!";
			errorTitle.Visible = false;
			// 
			// panel3
			// 
			panel3.Controls.Add(label6);
			panel3.Controls.Add(searchTitle);
			panel3.Controls.Add(label4);
			panel3.Dock = DockStyle.Fill;
			panel3.Location = new Point(5, 6);
			panel3.Margin = new Padding(5, 6, 5, 6);
			panel3.Name = "panel3";
			panel3.Size = new Size(828, 55);
			panel3.TabIndex = 1;
			// 
			// label6
			// 
			label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			label6.AutoSize = true;
			label6.Location = new Point(292, 12);
			label6.Margin = new Padding(5, 0, 5, 0);
			label6.Name = "label6";
			label6.Size = new Size(63, 25);
			label6.TabIndex = 2;
			label6.Text = "Поиск";
			// 
			// searchTitle
			// 
			searchTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			searchTitle.Location = new Point(360, 6);
			searchTitle.Margin = new Padding(5, 6, 5, 6);
			searchTitle.Name = "searchTitle";
			searchTitle.Size = new Size(461, 31);
			searchTitle.TabIndex = 1;
			searchTitle.TextChanged += searchTitle_TextChanged;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(5, 12);
			label4.Margin = new Padding(5, 0, 5, 0);
			label4.Name = "label4";
			label4.Size = new Size(201, 25);
			label4.TabIndex = 0;
			label4.Text = "Наименование работы";
			// 
			// titleListBox
			// 
			titleListBox.Dock = DockStyle.Fill;
			titleListBox.FormattingEnabled = true;
			titleListBox.ItemHeight = 25;
			titleListBox.Location = new Point(5, 73);
			titleListBox.Margin = new Padding(5, 6, 5, 6);
			titleListBox.Name = "titleListBox";
			titleListBox.Size = new Size(828, 606);
			titleListBox.TabIndex = 2;
			titleListBox.SelectedIndexChanged += titleListBox_SelectedIndexChanged;
			// 
			// WorkForm
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(2185, 1416);
			Controls.Add(tableLayoutPanel1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(5, 6, 5, 6);
			Name = "WorkForm";
			Text = "Список работ";
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel2.ResumeLayout(false);
			tableLayoutPanel2.PerformLayout();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			tableLayoutPanel3.ResumeLayout(false);
			tableLayoutPanel3.PerformLayout();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)inputAmount).EndInit();
			groupBox1.ResumeLayout(false);
			tableLayoutPanel4.ResumeLayout(false);
			tableLayoutPanel4.PerformLayout();
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Button deleteButton;
		private TableLayoutPanel tableLayoutPanel1;
		private TableLayoutPanel tableLayoutPanel2;
		private Button saveExcelButton;
		private Panel panel1;
		private Button editButton;
		private Button addButton;
		private Label errorAddress;
		private Label label1;
		private TextBox inputAddress;
		private DataGridView dataGridView1;
		private TableLayoutPanel tableLayoutPanel3;
		private GroupBox groupBox1;
		private ListBox typeListBox;
		private TableLayoutPanel tableLayoutPanel4;
		private Label errorTitle;
		private Panel panel3;
		private Label label6;
		private TextBox searchTitle;
		private Label label4;
		private ListBox titleListBox;
		private Label label2;
		private TextBox finalSum;
		private DateTimePicker dateTimePicker1;
		private SaveFileDialog saveFileDialog1;
		private Panel panel2;
		private Label errorAmount;
		private Label unitLabel;
		private NumericUpDown inputAmount;
		private Label label5;
		private Button cancelButton;
		private Button okButton;
		private Button minusButton;
		private Button plusButton;
	}
}