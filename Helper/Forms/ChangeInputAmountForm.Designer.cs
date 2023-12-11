namespace Helper.Forms
{
	partial class ChangeInputAmountForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeInputAmountForm));
			okButton = new Button();
			cancelButton = new Button();
			inputValue = new NumericUpDown();
			errorLabel = new Label();
			unitLabel = new Label();
			((System.ComponentModel.ISupportInitialize)inputValue).BeginInit();
			SuspendLayout();
			// 
			// okButton
			// 
			okButton.Image = (Image)resources.GetObject("okButton.Image");
			okButton.Location = new Point(176, 81);
			okButton.Name = "okButton";
			okButton.Size = new Size(145, 44);
			okButton.TabIndex = 0;
			okButton.Text = "OK";
			okButton.TextAlign = ContentAlignment.MiddleRight;
			okButton.TextImageRelation = TextImageRelation.ImageBeforeText;
			okButton.UseVisualStyleBackColor = true;
			okButton.Click += okButton_Click;
			// 
			// cancelButton
			// 
			cancelButton.Image = (Image)resources.GetObject("cancelButton.Image");
			cancelButton.Location = new Point(327, 81);
			cancelButton.Name = "cancelButton";
			cancelButton.Size = new Size(145, 44);
			cancelButton.TabIndex = 1;
			cancelButton.Text = "Отмена";
			cancelButton.TextAlign = ContentAlignment.MiddleRight;
			cancelButton.TextImageRelation = TextImageRelation.ImageBeforeText;
			cancelButton.UseVisualStyleBackColor = true;
			cancelButton.Click += cancelButton_Click;
			// 
			// inputValue
			// 
			inputValue.DecimalPlaces = 3;
			inputValue.Location = new Point(12, 12);
			inputValue.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
			inputValue.Name = "inputValue";
			inputValue.Size = new Size(309, 31);
			inputValue.TabIndex = 2;
			inputValue.Enter += inputValue_Enter;
			// 
			// errorLabel
			// 
			errorLabel.AutoSize = true;
			errorLabel.ForeColor = Color.Red;
			errorLabel.Location = new Point(12, 46);
			errorLabel.Name = "errorLabel";
			errorLabel.Size = new Size(78, 25);
			errorLabel.TabIndex = 3;
			errorLabel.Text = "Ошибка";
			errorLabel.Visible = false;
			// 
			// unitLabel
			// 
			unitLabel.AutoSize = true;
			unitLabel.ForeColor = SystemColors.ControlText;
			unitLabel.Location = new Point(327, 14);
			unitLabel.Name = "unitLabel";
			unitLabel.Size = new Size(70, 25);
			unitLabel.TabIndex = 4;
			unitLabel.Text = "ед.изм.";
			// 
			// ChangeInputAmountForm
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(484, 137);
			Controls.Add(unitLabel);
			Controls.Add(errorLabel);
			Controls.Add(inputValue);
			Controls.Add(cancelButton);
			Controls.Add(okButton);
			Name = "ChangeInputAmountForm";
			Text = "ChangeInputAmountForm";
			((System.ComponentModel.ISupportInitialize)inputValue).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button okButton;
		private Button cancelButton;
		private NumericUpDown inputValue;
		private Label errorLabel;
		private Label unitLabel;
	}
}