namespace Helper.Forms
{
	partial class WorkTitleForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkTitleForm));
			typesListBox = new ListBox();
			label2 = new Label();
			searchType = new TextBox();
			unitsGroupBox = new GroupBox();
			radioButton6 = new RadioButton();
			radioButton5 = new RadioButton();
			radioButton4 = new RadioButton();
			radioButton3 = new RadioButton();
			radioButton2 = new RadioButton();
			radioButton1 = new RadioButton();
			label3 = new Label();
			inputTitle = new TextBox();
			label4 = new Label();
			inputPrice = new NumericUpDown();
			okButton = new Button();
			cancelButton = new Button();
			addTypeButton = new Button();
			typesGroupBox = new GroupBox();
			errorTypeLabel = new Label();
			deleteTypeButton = new Button();
			editTypeButton = new Button();
			errorTitleLabel = new Label();
			unitsGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)inputPrice).BeginInit();
			typesGroupBox.SuspendLayout();
			SuspendLayout();
			// 
			// typesListBox
			// 
			typesListBox.FormattingEnabled = true;
			typesListBox.ItemHeight = 25;
			typesListBox.Location = new Point(10, 94);
			typesListBox.Margin = new Padding(5, 6, 5, 6);
			typesListBox.Name = "typesListBox";
			typesListBox.Size = new Size(1181, 304);
			typesListBox.TabIndex = 0;
			typesListBox.SelectedIndexChanged += typesListBox_SelectedIndexChanged;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(545, 48);
			label2.Margin = new Padding(5, 0, 5, 0);
			label2.Name = "label2";
			label2.Size = new Size(63, 25);
			label2.TabIndex = 2;
			label2.Text = "Поиск";
			// 
			// searchType
			// 
			searchType.Location = new Point(617, 42);
			searchType.Margin = new Padding(5, 6, 5, 6);
			searchType.Name = "searchType";
			searchType.Size = new Size(574, 31);
			searchType.TabIndex = 3;
			searchType.TextChanged += searchType_TextChanged;
			// 
			// unitsGroupBox
			// 
			unitsGroupBox.Controls.Add(radioButton6);
			unitsGroupBox.Controls.Add(radioButton5);
			unitsGroupBox.Controls.Add(radioButton4);
			unitsGroupBox.Controls.Add(radioButton3);
			unitsGroupBox.Controls.Add(radioButton2);
			unitsGroupBox.Controls.Add(radioButton1);
			unitsGroupBox.Location = new Point(20, 560);
			unitsGroupBox.Margin = new Padding(5, 6, 5, 6);
			unitsGroupBox.Name = "unitsGroupBox";
			unitsGroupBox.Padding = new Padding(5, 6, 5, 6);
			unitsGroupBox.Size = new Size(638, 110);
			unitsGroupBox.TabIndex = 4;
			unitsGroupBox.TabStop = false;
			unitsGroupBox.Text = "Единицы измерения";
			// 
			// radioButton6
			// 
			radioButton6.AutoSize = true;
			radioButton6.Location = new Point(498, 38);
			radioButton6.Margin = new Padding(5, 6, 5, 6);
			radioButton6.Name = "radioButton6";
			radioButton6.Size = new Size(114, 29);
			radioButton6.TabIndex = 5;
			radioButton6.Text = "комплект";
			radioButton6.UseVisualStyleBackColor = true;
			// 
			// radioButton5
			// 
			radioButton5.AutoSize = true;
			radioButton5.Location = new Point(397, 38);
			radioButton5.Margin = new Padding(5, 6, 5, 6);
			radioButton5.Name = "radioButton5";
			radioButton5.Size = new Size(84, 29);
			radioButton5.TabIndex = 4;
			radioButton5.Text = "тонна";
			radioButton5.UseVisualStyleBackColor = true;
			// 
			// radioButton4
			// 
			radioButton4.AutoSize = true;
			radioButton4.Location = new Point(295, 38);
			radioButton4.Margin = new Padding(5, 6, 5, 6);
			radioButton4.Name = "radioButton4";
			radioButton4.Size = new Size(83, 29);
			radioButton4.TabIndex = 3;
			radioButton4.Text = "точка";
			radioButton4.UseVisualStyleBackColor = true;
			// 
			// radioButton3
			// 
			radioButton3.AutoSize = true;
			radioButton3.Location = new Point(190, 38);
			radioButton3.Margin = new Padding(5, 6, 5, 6);
			radioButton3.Name = "radioButton3";
			radioButton3.Size = new Size(85, 29);
			radioButton3.TabIndex = 2;
			radioButton3.Text = "штука";
			radioButton3.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			radioButton2.AutoSize = true;
			radioButton2.Location = new Point(105, 38);
			radioButton2.Margin = new Padding(5, 6, 5, 6);
			radioButton2.Name = "radioButton2";
			radioButton2.Size = new Size(68, 29);
			radioButton2.TabIndex = 1;
			radioButton2.Text = "м.п.";
			radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton1
			// 
			radioButton1.AutoSize = true;
			radioButton1.Checked = true;
			radioButton1.Location = new Point(10, 38);
			radioButton1.Margin = new Padding(5, 6, 5, 6);
			radioButton1.Name = "radioButton1";
			radioButton1.Size = new Size(57, 29);
			radioButton1.TabIndex = 0;
			radioButton1.TabStop = true;
			radioButton1.Text = "м²";
			radioButton1.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(30, 488);
			label3.Margin = new Padding(5, 0, 5, 0);
			label3.Name = "label3";
			label3.Size = new Size(201, 25);
			label3.TabIndex = 5;
			label3.Text = "Наименование работы";
			// 
			// inputTitle
			// 
			inputTitle.Location = new Point(242, 483);
			inputTitle.Margin = new Padding(5, 6, 5, 6);
			inputTitle.Name = "inputTitle";
			inputTitle.Size = new Size(969, 31);
			inputTitle.TabIndex = 6;
			inputTitle.TextChanged += inputTitle_TextChanged;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(30, 685);
			label4.Margin = new Padding(5, 0, 5, 0);
			label4.Name = "label4";
			label4.Size = new Size(149, 25);
			label4.TabIndex = 7;
			label4.Text = "Цена за единицу";
			// 
			// inputPrice
			// 
			inputPrice.DecimalPlaces = 2;
			inputPrice.ImeMode = ImeMode.NoControl;
			inputPrice.Location = new Point(195, 681);
			inputPrice.Margin = new Padding(5, 6, 5, 6);
			inputPrice.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
			inputPrice.Name = "inputPrice";
			inputPrice.Size = new Size(200, 31);
			inputPrice.TabIndex = 8;
			// 
			// okButton
			// 
			okButton.Image = (Image)resources.GetObject("okButton.Image");
			okButton.Location = new Point(953, 693);
			okButton.Margin = new Padding(5, 6, 5, 6);
			okButton.Name = "okButton";
			okButton.Size = new Size(130, 44);
			okButton.TabIndex = 9;
			okButton.Text = "OK";
			okButton.TextAlign = ContentAlignment.MiddleRight;
			okButton.TextImageRelation = TextImageRelation.ImageBeforeText;
			okButton.UseVisualStyleBackColor = true;
			okButton.Click += okButton_Click;
			// 
			// cancelButton
			// 
			cancelButton.Image = (Image)resources.GetObject("cancelButton.Image");
			cancelButton.Location = new Point(1093, 693);
			cancelButton.Margin = new Padding(5, 6, 5, 6);
			cancelButton.Name = "cancelButton";
			cancelButton.Size = new Size(130, 44);
			cancelButton.TabIndex = 10;
			cancelButton.Text = "Отмена";
			cancelButton.TextAlign = ContentAlignment.MiddleRight;
			cancelButton.TextImageRelation = TextImageRelation.ImageBeforeText;
			cancelButton.UseVisualStyleBackColor = true;
			cancelButton.Click += cancelButton_Click;
			// 
			// addTypeButton
			// 
			addTypeButton.Image = (Image)resources.GetObject("addTypeButton.Image");
			addTypeButton.Location = new Point(10, 38);
			addTypeButton.Margin = new Padding(5, 6, 5, 6);
			addTypeButton.Name = "addTypeButton";
			addTypeButton.Size = new Size(130, 44);
			addTypeButton.TabIndex = 11;
			addTypeButton.Text = "Добавить";
			addTypeButton.TextAlign = ContentAlignment.MiddleRight;
			addTypeButton.TextImageRelation = TextImageRelation.ImageBeforeText;
			addTypeButton.UseVisualStyleBackColor = true;
			addTypeButton.Click += addTypeButton_Click;
			// 
			// typesGroupBox
			// 
			typesGroupBox.Controls.Add(errorTypeLabel);
			typesGroupBox.Controls.Add(deleteTypeButton);
			typesGroupBox.Controls.Add(editTypeButton);
			typesGroupBox.Controls.Add(addTypeButton);
			typesGroupBox.Controls.Add(typesListBox);
			typesGroupBox.Controls.Add(label2);
			typesGroupBox.Controls.Add(searchType);
			typesGroupBox.Location = new Point(20, 23);
			typesGroupBox.Margin = new Padding(5, 6, 5, 6);
			typesGroupBox.Name = "typesGroupBox";
			typesGroupBox.Padding = new Padding(5, 6, 5, 6);
			typesGroupBox.Size = new Size(1203, 448);
			typesGroupBox.TabIndex = 12;
			typesGroupBox.TabStop = false;
			typesGroupBox.Text = "Вид работы";
			// 
			// errorTypeLabel
			// 
			errorTypeLabel.AutoSize = true;
			errorTypeLabel.FlatStyle = FlatStyle.System;
			errorTypeLabel.ForeColor = Color.Red;
			errorTypeLabel.Location = new Point(10, 408);
			errorTypeLabel.Margin = new Padding(5, 0, 5, 0);
			errorTypeLabel.Name = "errorTypeLabel";
			errorTypeLabel.Size = new Size(258, 25);
			errorTypeLabel.TabIndex = 13;
			errorTypeLabel.Text = "Выберите позицию из списка!";
			errorTypeLabel.Visible = false;
			// 
			// deleteTypeButton
			// 
			deleteTypeButton.Image = (Image)resources.GetObject("deleteTypeButton.Image");
			deleteTypeButton.Location = new Point(290, 38);
			deleteTypeButton.Margin = new Padding(5, 6, 5, 6);
			deleteTypeButton.Name = "deleteTypeButton";
			deleteTypeButton.Size = new Size(130, 44);
			deleteTypeButton.TabIndex = 13;
			deleteTypeButton.Text = "Удалить";
			deleteTypeButton.TextAlign = ContentAlignment.MiddleRight;
			deleteTypeButton.TextImageRelation = TextImageRelation.ImageBeforeText;
			deleteTypeButton.UseVisualStyleBackColor = true;
			deleteTypeButton.Click += deleteTypeButton_Click;
			// 
			// editTypeButton
			// 
			editTypeButton.Image = (Image)resources.GetObject("editTypeButton.Image");
			editTypeButton.Location = new Point(150, 38);
			editTypeButton.Margin = new Padding(5, 6, 5, 6);
			editTypeButton.Name = "editTypeButton";
			editTypeButton.Size = new Size(130, 44);
			editTypeButton.TabIndex = 12;
			editTypeButton.Text = "Изменить";
			editTypeButton.TextAlign = ContentAlignment.MiddleRight;
			editTypeButton.TextImageRelation = TextImageRelation.ImageBeforeText;
			editTypeButton.UseVisualStyleBackColor = true;
			editTypeButton.Click += editTypeButton_Click;
			// 
			// errorTitleLabel
			// 
			errorTitleLabel.AutoSize = true;
			errorTitleLabel.FlatStyle = FlatStyle.System;
			errorTitleLabel.ForeColor = Color.Red;
			errorTitleLabel.Location = new Point(242, 529);
			errorTitleLabel.Margin = new Padding(5, 0, 5, 0);
			errorTitleLabel.Name = "errorTitleLabel";
			errorTitleLabel.Size = new Size(146, 25);
			errorTitleLabel.TabIndex = 14;
			errorTitleLabel.Text = "Заполните поле!";
			errorTitleLabel.Visible = false;
			// 
			// WorkTitleForm
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1253, 752);
			Controls.Add(errorTitleLabel);
			Controls.Add(typesGroupBox);
			Controls.Add(cancelButton);
			Controls.Add(okButton);
			Controls.Add(inputPrice);
			Controls.Add(label4);
			Controls.Add(inputTitle);
			Controls.Add(label3);
			Controls.Add(unitsGroupBox);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(5, 6, 5, 6);
			Name = "WorkTitleForm";
			Text = "WorkTitleForm";
			unitsGroupBox.ResumeLayout(false);
			unitsGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)inputPrice).EndInit();
			typesGroupBox.ResumeLayout(false);
			typesGroupBox.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ListBox typesListBox;
		private Label label2;
		private TextBox searchType;
		private GroupBox unitsGroupBox;
		private Label label3;
		private TextBox inputTitle;
		private RadioButton radioButton4;
		private RadioButton radioButton3;
		private RadioButton radioButton2;
		private RadioButton radioButton1;
		private RadioButton radioButton5;
		private Label label4;
		private NumericUpDown inputPrice;
		private Button okButton;
		private Button cancelButton;
		private Button addTypeButton;
		private GroupBox typesGroupBox;
		private Button deleteTypeButton;
		private Button editTypeButton;
		private Label errorTypeLabel;
		private Label errorTitleLabel;
		private RadioButton radioButton6;
	}
}