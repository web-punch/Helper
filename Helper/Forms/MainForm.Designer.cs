namespace Helper.Forms
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			priceButton = new Button();
			workButton = new Button();
			SuspendLayout();
			// 
			// priceButton
			// 
			priceButton.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
			priceButton.Location = new Point(20, 23);
			priceButton.Margin = new Padding(5, 6, 5, 6);
			priceButton.Name = "priceButton";
			priceButton.Size = new Size(167, 96);
			priceButton.TabIndex = 0;
			priceButton.Text = "Прайс";
			priceButton.UseVisualStyleBackColor = true;
			priceButton.Click += priceButton_Click;
			// 
			// workButton
			// 
			workButton.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
			workButton.Location = new Point(197, 23);
			workButton.Margin = new Padding(5, 6, 5, 6);
			workButton.Name = "workButton";
			workButton.Size = new Size(167, 96);
			workButton.TabIndex = 1;
			workButton.Text = "Работа";
			workButton.UseVisualStyleBackColor = true;
			workButton.Click += workButton_Click;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(723, 287);
			Controls.Add(workButton);
			Controls.Add(priceButton);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(5, 6, 5, 6);
			Name = "MainForm";
			Text = "Помогатор";
			ResumeLayout(false);
		}

		#endregion

		private Button priceButton;
		private Button workButton;
	}
}