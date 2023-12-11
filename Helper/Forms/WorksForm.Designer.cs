namespace Helper.Forms
{
	partial class WorksForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorksForm));
			addButton = new Button();
			viewButton = new Button();
			searchWorks = new TextBox();
			label1 = new Label();
			dataGridView1 = new DataGridView();
			deleteButton = new Button();
			updateButton = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// addButton
			// 
			addButton.Image = (Image)resources.GetObject("addButton.Image");
			addButton.Location = new Point(14, 15);
			addButton.Margin = new Padding(5, 6, 5, 6);
			addButton.Name = "addButton";
			addButton.Size = new Size(145, 44);
			addButton.TabIndex = 0;
			addButton.Text = "Добавить";
			addButton.TextAlign = ContentAlignment.MiddleRight;
			addButton.TextImageRelation = TextImageRelation.ImageBeforeText;
			addButton.UseVisualStyleBackColor = true;
			addButton.Click += addButton_Click;
			// 
			// viewButton
			// 
			viewButton.Image = (Image)resources.GetObject("viewButton.Image");
			viewButton.Location = new Point(169, 15);
			viewButton.Margin = new Padding(5, 6, 5, 6);
			viewButton.Name = "viewButton";
			viewButton.Size = new Size(145, 44);
			viewButton.TabIndex = 1;
			viewButton.Text = "Просмотр";
			viewButton.TextAlign = ContentAlignment.MiddleRight;
			viewButton.TextImageRelation = TextImageRelation.ImageBeforeText;
			viewButton.UseVisualStyleBackColor = true;
			viewButton.Click += viewButton_Click;
			// 
			// searchWorks
			// 
			searchWorks.Location = new Point(808, 22);
			searchWorks.Margin = new Padding(5, 6, 5, 6);
			searchWorks.Name = "searchWorks";
			searchWorks.Size = new Size(607, 31);
			searchWorks.TabIndex = 2;
			searchWorks.TextChanged += searchWorks_TextChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(735, 25);
			label1.Margin = new Padding(5, 0, 5, 0);
			label1.Name = "label1";
			label1.Size = new Size(63, 25);
			label1.TabIndex = 3;
			label1.Text = "Поиск";
			// 
			// dataGridView1
			// 
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.AllowUserToDeleteRows = false;
			dataGridView1.AllowUserToResizeRows = false;
			dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(14, 71);
			dataGridView1.Margin = new Padding(5, 6, 5, 6);
			dataGridView1.MultiSelect = false;
			dataGridView1.Name = "dataGridView1";
			dataGridView1.ReadOnly = true;
			dataGridView1.RowHeadersVisible = false;
			dataGridView1.RowHeadersWidth = 62;
			dataGridView1.RowTemplate.Height = 23;
			dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView1.Size = new Size(1401, 779);
			dataGridView1.TabIndex = 4;
			// 
			// deleteButton
			// 
			deleteButton.Image = (Image)resources.GetObject("deleteButton.Image");
			deleteButton.Location = new Point(324, 15);
			deleteButton.Margin = new Padding(5, 6, 5, 6);
			deleteButton.Name = "deleteButton";
			deleteButton.Size = new Size(145, 44);
			deleteButton.TabIndex = 5;
			deleteButton.Text = "Удалить";
			deleteButton.TextAlign = ContentAlignment.MiddleRight;
			deleteButton.TextImageRelation = TextImageRelation.ImageBeforeText;
			deleteButton.UseVisualStyleBackColor = true;
			deleteButton.Click += deleteButton_Click;
			// 
			// updateButton
			// 
			updateButton.Image = (Image)resources.GetObject("updateButton.Image");
			updateButton.Location = new Point(479, 15);
			updateButton.Margin = new Padding(5, 6, 5, 6);
			updateButton.Name = "updateButton";
			updateButton.Size = new Size(145, 44);
			updateButton.TabIndex = 6;
			updateButton.Text = "Обновить";
			updateButton.TextAlign = ContentAlignment.MiddleRight;
			updateButton.TextImageRelation = TextImageRelation.ImageBeforeText;
			updateButton.UseVisualStyleBackColor = true;
			updateButton.Click += updateButton_Click;
			// 
			// WorksForm
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1429, 865);
			Controls.Add(updateButton);
			Controls.Add(deleteButton);
			Controls.Add(dataGridView1);
			Controls.Add(label1);
			Controls.Add(searchWorks);
			Controls.Add(viewButton);
			Controls.Add(addButton);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(5, 6, 5, 6);
			Name = "WorksForm";
			Text = "Выполненные работы";
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button addButton;
		private Button viewButton;
		private TextBox searchWorks;
		private Label label1;
		private DataGridView dataGridView1;
		private Button deleteButton;
		private Button updateButton;
	}
}