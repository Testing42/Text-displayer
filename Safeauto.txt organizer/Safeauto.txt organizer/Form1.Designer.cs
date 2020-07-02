namespace Safeauto.txt_organizer
{
	partial class Form1
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
			this.TxtButton = new System.Windows.Forms.Button();
			this.fileName = new System.Windows.Forms.TextBox();
			this.fileLocation = new System.Windows.Forms.TextBox();
			this.reset = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// TxtButton
			// 
			this.TxtButton.Location = new System.Drawing.Point(53, 21);
			this.TxtButton.Name = "TxtButton";
			this.TxtButton.Size = new System.Drawing.Size(85, 38);
			this.TxtButton.TabIndex = 0;
			this.TxtButton.Text = "Add .TXT";
			this.TxtButton.UseVisualStyleBackColor = true;
			this.TxtButton.Click += new System.EventHandler(this.TxtButton_Click);
			// 
			// fileName
			// 
			this.fileName.Location = new System.Drawing.Point(269, 21);
			this.fileName.Name = "fileName";
			this.fileName.ReadOnly = true;
			this.fileName.Size = new System.Drawing.Size(195, 20);
			this.fileName.TabIndex = 1;
			// 
			// fileLocation
			// 
			this.fileLocation.Location = new System.Drawing.Point(240, 82);
			this.fileLocation.Name = "fileLocation";
			this.fileLocation.ReadOnly = true;
			this.fileLocation.Size = new System.Drawing.Size(322, 20);
			this.fileLocation.TabIndex = 2;
			// 
			// reset
			// 
			this.reset.Location = new System.Drawing.Point(673, 383);
			this.reset.Name = "reset";
			this.reset.Size = new System.Drawing.Size(75, 23);
			this.reset.TabIndex = 3;
			this.reset.Text = "reset";
			this.reset.UseVisualStyleBackColor = true;
			this.reset.Click += new System.EventHandler(this.Reset_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(172, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "File Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(142, 82);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "File Location";
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(145, 127);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(499, 277);
			this.listBox1.TabIndex = 7;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.reset);
			this.Controls.Add(this.fileLocation);
			this.Controls.Add(this.fileName);
			this.Controls.Add(this.TxtButton);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button TxtButton;
		private System.Windows.Forms.TextBox fileName;
		private System.Windows.Forms.TextBox fileLocation;
		private System.Windows.Forms.Button reset;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox listBox1;
	}
}

