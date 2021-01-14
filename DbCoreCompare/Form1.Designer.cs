namespace DbCoreCompare
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
			this.btnCompare = new System.Windows.Forms.Button();
			this.btnConvert = new System.Windows.Forms.Button();
			this.txtXML = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnCompare
			// 
			this.btnCompare.Location = new System.Drawing.Point(32, 32);
			this.btnCompare.Name = "btnCompare";
			this.btnCompare.Size = new System.Drawing.Size(78, 29);
			this.btnCompare.TabIndex = 0;
			this.btnCompare.Text = "Compare";
			this.btnCompare.UseVisualStyleBackColor = true;
			this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
			// 
			// btnConvert
			// 
			this.btnConvert.Location = new System.Drawing.Point(128, 32);
			this.btnConvert.Name = "btnConvert";
			this.btnConvert.Size = new System.Drawing.Size(102, 29);
			this.btnConvert.TabIndex = 1;
			this.btnConvert.Text = "Convert";
			this.btnConvert.UseVisualStyleBackColor = true;
			this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
			// 
			// txtXML
			// 
			this.txtXML.Location = new System.Drawing.Point(12, 67);
			this.txtXML.Multiline = true;
			this.txtXML.Name = "txtXML";
			this.txtXML.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtXML.Size = new System.Drawing.Size(776, 371);
			this.txtXML.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.txtXML);
			this.Controls.Add(this.btnConvert);
			this.Controls.Add(this.btnCompare);
			this.Name = "Form1";
			this.Text = "DB Compare";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCompare;
		private System.Windows.Forms.Button btnConvert;
		private System.Windows.Forms.TextBox txtXML;
	}
}

