namespace ProcessViewer
{
    partial class Form2
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
            this.runButton = new MetroFramework.Controls.MetroButton();
            this.runTextBox = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // runButton
            // 
            this.runButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.runButton.Location = new System.Drawing.Point(307, 72);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(108, 23);
            this.runButton.TabIndex = 0;
            this.runButton.Text = "Run";
            this.runButton.UseSelectable = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // runTextBox
            // 
            // 
            // 
            // 
            this.runTextBox.CustomButton.Image = null;
            this.runTextBox.CustomButton.Location = new System.Drawing.Point(214, 1);
            this.runTextBox.CustomButton.Name = "";
            this.runTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.runTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.runTextBox.CustomButton.TabIndex = 1;
            this.runTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.runTextBox.CustomButton.UseSelectable = true;
            this.runTextBox.CustomButton.Visible = false;
            this.runTextBox.Lines = new string[0];
            this.runTextBox.Location = new System.Drawing.Point(53, 72);
            this.runTextBox.MaxLength = 32767;
            this.runTextBox.Name = "runTextBox";
            this.runTextBox.PasswordChar = '\0';
            this.runTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.runTextBox.SelectedText = "";
            this.runTextBox.SelectionLength = 0;
            this.runTextBox.SelectionStart = 0;
            this.runTextBox.ShortcutsEnabled = true;
            this.runTextBox.Size = new System.Drawing.Size(236, 23);
            this.runTextBox.TabIndex = 1;
            this.runTextBox.UseSelectable = true;
            this.runTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.runTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 133);
            this.Controls.Add(this.runTextBox);
            this.Controls.Add(this.runButton);
            this.Name = "Form2";
            this.Text = "Run Process ";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton runButton;
        private MetroFramework.Controls.MetroTextBox runTextBox;
    }
}