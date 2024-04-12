namespace GlaciteCaveApiApp
{
	partial class Form1
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
			lookupButton = new Button();
			usernameTextBox = new TextBox();
			hotmLabel = new Label();
			profileComboBox = new ComboBox();
			apiKeyTextBox = new TextBox();
			potmLabel = new Label();
			glacitePowderLabel = new Label();
			mageLabel = new Label();
			bowmanLabel = new Label();
			muttLabel = new Label();
			caverLabel = new Label();
			SuspendLayout();
			// 
			// lookupButton
			// 
			lookupButton.Location = new Point(204, 12);
			lookupButton.Name = "lookupButton";
			lookupButton.Size = new Size(75, 23);
			lookupButton.TabIndex = 0;
			lookupButton.Text = "Lookup";
			lookupButton.UseVisualStyleBackColor = true;
			lookupButton.Click += lookupButton_Click;
			// 
			// usernameTextBox
			// 
			usernameTextBox.Location = new Point(12, 12);
			usernameTextBox.Name = "usernameTextBox";
			usernameTextBox.Size = new Size(186, 23);
			usernameTextBox.TabIndex = 1;
			usernameTextBox.Text = "put mc ign here";
			// 
			// hotmLabel
			// 
			hotmLabel.AutoSize = true;
			hotmLabel.Location = new Point(12, 51);
			hotmLabel.Name = "hotmLabel";
			hotmLabel.Size = new Size(44, 15);
			hotmLabel.TabIndex = 5;
			hotmLabel.Text = "HOTM:";
			// 
			// profileComboBox
			// 
			profileComboBox.FormattingEnabled = true;
			profileComboBox.Location = new Point(285, 12);
			profileComboBox.Name = "profileComboBox";
			profileComboBox.Size = new Size(171, 23);
			profileComboBox.TabIndex = 6;
			profileComboBox.SelectedIndexChanged += profileComboBox_SelectedIndexChanged;
			// 
			// apiKeyTextBox
			// 
			apiKeyTextBox.Location = new Point(641, 13);
			apiKeyTextBox.Name = "apiKeyTextBox";
			apiKeyTextBox.Size = new Size(175, 23);
			apiKeyTextBox.TabIndex = 8;
			apiKeyTextBox.Text = "api key goes here";
			// 
			// potmLabel
			// 
			potmLabel.AutoSize = true;
			potmLabel.Location = new Point(12, 66);
			potmLabel.Name = "potmLabel";
			potmLabel.Size = new Size(42, 15);
			potmLabel.TabIndex = 9;
			potmLabel.Text = "POTM:";
			// 
			// glacitePowderLabel
			// 
			glacitePowderLabel.AutoSize = true;
			glacitePowderLabel.Location = new Point(12, 81);
			glacitePowderLabel.Name = "glacitePowderLabel";
			glacitePowderLabel.Size = new Size(89, 15);
			glacitePowderLabel.TabIndex = 10;
			glacitePowderLabel.Text = "Glacite Powder:";
			// 
			// mageLabel
			// 
			mageLabel.AutoSize = true;
			mageLabel.Location = new Point(285, 51);
			mageLabel.Name = "mageLabel";
			mageLabel.Size = new Size(79, 15);
			mageLabel.TabIndex = 11;
			mageLabel.Text = "Glacite Mage:";
			// 
			// bowmanLabel
			// 
			bowmanLabel.AutoSize = true;
			bowmanLabel.Location = new Point(285, 66);
			bowmanLabel.Name = "bowmanLabel";
			bowmanLabel.Size = new Size(96, 15);
			bowmanLabel.TabIndex = 12;
			bowmanLabel.Text = "Glacite Bowman:";
			// 
			// muttLabel
			// 
			muttLabel.AutoSize = true;
			muttLabel.Location = new Point(285, 81);
			muttLabel.Name = "muttLabel";
			muttLabel.Size = new Size(75, 15);
			muttLabel.TabIndex = 13;
			muttLabel.Text = "Glacite Mutt:";
			// 
			// caverLabel
			// 
			caverLabel.AutoSize = true;
			caverLabel.Location = new Point(285, 96);
			caverLabel.Name = "caverLabel";
			caverLabel.Size = new Size(79, 15);
			caverLabel.TabIndex = 14;
			caverLabel.Text = "Glacite Caver:";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(851, 160);
			Controls.Add(caverLabel);
			Controls.Add(muttLabel);
			Controls.Add(bowmanLabel);
			Controls.Add(mageLabel);
			Controls.Add(glacitePowderLabel);
			Controls.Add(potmLabel);
			Controls.Add(apiKeyTextBox);
			Controls.Add(profileComboBox);
			Controls.Add(hotmLabel);
			Controls.Add(usernameTextBox);
			Controls.Add(lookupButton);
			Name = "Form1";
			Text = "Glacite Api App (Hydar)";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button lookupButton;
		private TextBox usernameTextBox;
		private Label hotmLabel;
		private ComboBox profileComboBox;
		private TextBox apiKeyTextBox;
		private Label potmLabel;
		private Label glacitePowderLabel;
		private Label mageLabel;
		private Label bowmanLabel;
		private Label muttLabel;
		private Label caverLabel;
	}
}
