namespace Helper.Forms
{
	partial class WorkTypeForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkTypeForm));
			label1 = new Label();
			inputType = new TextBox();
			errorLabel = new Label();
			okButton = new Button();
			cuncelButton = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(20, 29);
			label1.Margin = new Padding(5, 0, 5, 0);
			label1.Name = "label1";
			label1.Size = new Size(108, 25);
			label1.TabIndex = 0;
			label1.Text = "Вид работы";
			// 
			// inputType
			// 
			inputType.Location = new Point(142, 23);
			inputType.Margin = new Padding(5, 6, 5, 6);
			inputType.Name = "inputType";
			inputType.Size = new Size(584, 31);
			inputType.TabIndex = 1;
			inputType.TextChanged += inputType_TextChanged;
			// 
			// errorLabel
			// 
			errorLabel.AutoSize = true;
			errorLabel.ForeColor = Color.Red;
			errorLabel.Location = new Point(142, 69);
			errorLabel.Margin = new Padding(5, 0, 5, 0);
			errorLabel.Name = "errorLabel";
			errorLabel.Size = new Size(78, 25);
			errorLabel.TabIndex = 4;
			errorLabel.Text = "Ошибка";
			errorLabel.Visible = false;
			// 
			// okButton
			// 
			okButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			okButton.Image = (Image)resources.GetObject("okButton.Image");
			okButton.Location = new Point(480, 96);
			okButton.Name = "okButton";
			okButton.Size = new Size(120, 44);
			okButton.TabIndex = 5;
			okButton.Text = "OK";
			okButton.TextAlign = ContentAlignment.MiddleRight;
			okButton.TextImageRelation = TextImageRelation.ImageBeforeText;
			okButton.UseVisualStyleBackColor = true;
			okButton.Click += okButton_Click;
			// 
			// cuncelButton
			// 
			cuncelButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			cuncelButton.Image = (Image)resources.GetObject("cuncelButton.Image");
			cuncelButton.Location = new Point(606, 96);
			cuncelButton.Name = "cuncelButton";
			cuncelButton.Size = new Size(120, 44);
			cuncelButton.TabIndex = 6;
			cuncelButton.Text = "Отмена";
			cuncelButton.TextAlign = ContentAlignment.MiddleRight;
			cuncelButton.TextImageRelation = TextImageRelation.ImageBeforeText;
			cuncelButton.UseVisualStyleBackColor = true;
			cuncelButton.Click += cuncelButton_Click;
			// 
			// WorkTypeForm
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(757, 152);
			Controls.Add(cuncelButton);
			Controls.Add(okButton);
			Controls.Add(errorLabel);
			Controls.Add(inputType);
			Controls.Add(label1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(5, 6, 5, 6);
			Name = "WorkTypeForm";
			Text = "WorkTypeForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox inputType;
		private Label errorLabel;
		private Button okButton;
		private Button cuncelButton;
	}
}