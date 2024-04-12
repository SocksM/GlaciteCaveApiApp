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
			loadButton = new Button();
			apiKeyTextBox = new TextBox();
			potmLabel = new Label();
			glacitePowderLabel = new Label();
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
			// 
			// loadButton
			// 
			loadButton.Location = new Point(462, 11);
			loadButton.Name = "loadButton";
			loadButton.Size = new Size(75, 23);
			loadButton.TabIndex = 7;
			loadButton.Text = "Load";
			loadButton.UseVisualStyleBackColor = true;
			loadButton.Click += loadButton_Click;
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
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(851, 160);
			Controls.Add(glacitePowderLabel);
			Controls.Add(potmLabel);
			Controls.Add(apiKeyTextBox);
			Controls.Add(loadButton);
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
		private Button loadButton;
		private TextBox apiKeyTextBox;
		private Label potmLabel;
		private Label glacitePowderLabel;
	}
}
