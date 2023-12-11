namespace Helper.Forms
{
	partial class WorkPriceForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkPriceForm));
			addButton = new Button();
			editButton = new Button();
			dataGridView1 = new DataGridView();
			label1 = new Label();
			searchTitle = new TextBox();
			archiveButton = new Button();
			updateButton = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// addButton
			// 
			addButton.Image = (Image)resources.GetObject("addButton.Image");
			addButton.Location = new Point(20, 15);
			addButton.Margin = new Padding(5, 6, 5, 6);
			addButton.Name = "addButton";
			addButton.Size = new Size(140, 44);
			addButton.TabIndex = 0;
			addButton.Text = "Добавить";
			addButton.TextAlign = ContentAlignment.MiddleRight;
			addButton.TextImageRelation = TextImageRelation.ImageBeforeText;
			addButton.UseVisualStyleBackColor = true;
			addButton.Click += addButton_Click;
			// 
			// editButton
			// 
			editButton.Image = (Image)resources.GetObject("editButton.Image");
			editButton.Location = new Point(170, 15);
			editButton.Margin = new Padding(5, 6, 5, 6);
			editButton.Name = "editButton";
			editButton.Size = new Size(140, 44);
			editButton.TabIndex = 1;
			editButton.Text = "Изменить";
			editButton.TextAlign = ContentAlignment.MiddleRight;
			editButton.TextImageRelation = TextImageRelation.ImageBeforeText;
			editButton.UseVisualStyleBackColor = true;
			editButton.Click += editButton_Click;
			// 
			// dataGridView1
			// 
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.AllowUserToDeleteRows = false;
			dataGridView1.AllowUserToResizeRows = false;
			dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(20, 71);
			dataGridView1.Margin = new Padding(5, 6, 5, 6);
			dataGridView1.MultiSelect = false;
			dataGridView1.Name = "dataGridView1";
			dataGridView1.ReadOnly = true;
			dataGridView1.RowHeadersVisible = false;
			dataGridView1.RowHeadersWidth = 62;
			dataGridView1.RowTemplate.Height = 23;
			dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView1.Size = new Size(1424, 763);
			dataGridView1.TabIndex = 6;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(720, 25);
			label1.Margin = new Padding(5, 0, 5, 0);
			label1.Name = "label1";
			label1.Size = new Size(63, 25);
			label1.TabIndex = 7;
			label1.Text = "Поиск";
			// 
			// searchTitle
			// 
			searchTitle.Location = new Point(793, 22);
			searchTitle.Margin = new Padding(5, 6, 5, 6);
			searchTitle.Name = "searchTitle";
			searchTitle.Size = new Size(651, 31);
			searchTitle.TabIndex = 8;
			searchTitle.TextChanged += searchTitle_TextChanged;
			// 
			// archiveButton
			// 
			archiveButton.Image = (Image)resources.GetObject("archiveButton.Image");
			archiveButton.Location = new Point(470, 15);
			archiveButton.Margin = new Padding(5, 6, 5, 6);
			archiveButton.Name = "archiveButton";
			archiveButton.Size = new Size(140, 44);
			archiveButton.TabIndex = 9;
			archiveButton.Text = "Архив";
			archiveButton.TextAlign = ContentAlignment.MiddleRight;
			archiveButton.TextImageRelation = TextImageRelation.ImageBeforeText;
			archiveButton.UseVisualStyleBackColor = true;
			archiveButton.Click += archiveButton_Click;
			// 
			// updateButton
			// 
			updateButton.Image = (Image)resources.GetObject("updateButton.Image");
			updateButton.Location = new Point(320, 15);
			updateButton.Margin = new Padding(5, 6, 5, 6);
			updateButton.Name = "updateButton";
			updateButton.Size = new Size(140, 44);
			updateButton.TabIndex = 10;
			updateButton.Text = "Обновить";
			updateButton.TextAlign = ContentAlignment.MiddleRight;
			updateButton.TextImageRelation = TextImageRelation.ImageBeforeText;
			updateButton.UseVisualStyleBackColor = true;
			updateButton.Click += updateButton_Click;
			// 
			// WorkPriceForm
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1464, 865);
			Controls.Add(updateButton);
			Controls.Add(archiveButton);
			Controls.Add(searchTitle);
			Controls.Add(label1);
			Controls.Add(dataGridView1);
			Controls.Add(editButton);
			Controls.Add(addButton);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(5, 6, 5, 6);
			Name = "WorkPriceForm";
			Text = "Прайс на работы";
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button addButton;
		private Button editButton;
		private DataGridView dataGridView1;
		private Label label1;
		private TextBox searchTitle;
		private Button archiveButton;
		private Button updateButton;
	}
}