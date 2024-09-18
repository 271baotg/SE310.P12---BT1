using System.Windows.Forms;

namespace Farm
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
            this.txtCowCount = new System.Windows.Forms.TextBox();
            this.txtSheepCount = new System.Windows.Forms.TextBox();
            this.txtGoatCount = new System.Windows.Forms.TextBox();
            this.Nhap = new System.Windows.Forms.Button();
            this.TiengKeu = new System.Windows.Forms.Button();
            this.PhanTich = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCowCount
            // 
            this.txtCowCount.Location = new System.Drawing.Point(310, 120);
            this.txtCowCount.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtCowCount.Name = "txtCowCount";
            this.txtCowCount.Size = new System.Drawing.Size(175, 31);
            this.txtCowCount.TabIndex = 0;
            // 
            // txtSheepCount
            // 
            this.txtSheepCount.Location = new System.Drawing.Point(306, 252);
            this.txtSheepCount.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtSheepCount.Name = "txtSheepCount";
            this.txtSheepCount.Size = new System.Drawing.Size(179, 31);
            this.txtSheepCount.TabIndex = 1;
            // 
            // txtGoatCount
            // 
            this.txtGoatCount.Location = new System.Drawing.Point(304, 392);
            this.txtGoatCount.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtGoatCount.Name = "txtGoatCount";
            this.txtGoatCount.Size = new System.Drawing.Size(179, 31);
            this.txtGoatCount.TabIndex = 2;
            // 
            // Nhap
            // 
            this.Nhap.Location = new System.Drawing.Point(542, 518);
            this.Nhap.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Nhap.Name = "Nhap";
            this.Nhap.Size = new System.Drawing.Size(161, 51);
            this.Nhap.TabIndex = 3;
            this.Nhap.Text = "Nhập";
            this.Nhap.UseVisualStyleBackColor = true;
            this.Nhap.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // TiengKeu
            // 
            this.TiengKeu.Location = new System.Drawing.Point(81, 518);
            this.TiengKeu.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.TiengKeu.Name = "TiengKeu";
            this.TiengKeu.Size = new System.Drawing.Size(161, 51);
            this.TiengKeu.TabIndex = 4;
            this.TiengKeu.Text = "Tiếng Kêu";
            this.TiengKeu.UseVisualStyleBackColor = true;
            this.TiengKeu.Click += new System.EventHandler(this.btnHearSounds_Click);
            // 
            // PhanTich
            // 
            this.PhanTich.Location = new System.Drawing.Point(312, 518);
            this.PhanTich.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.PhanTich.Name = "PhanTich";
            this.PhanTich.Size = new System.Drawing.Size(161, 51);
            this.PhanTich.TabIndex = 5;
            this.PhanTich.Text = "Phân Tích";
            this.PhanTich.UseVisualStyleBackColor = true;
            this.PhanTich.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Số Lượng Bò";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 195);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Số Lượng Cừu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 335);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Số Lượng Dê";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 862);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PhanTich);
            this.Controls.Add(this.TiengKeu);
            this.Controls.Add(this.Nhap);
            this.Controls.Add(this.txtGoatCount);
            this.Controls.Add(this.txtSheepCount);
            this.Controls.Add(this.txtCowCount);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private TextBox txtCowCount;
		private TextBox txtSheepCount;
		private TextBox txtGoatCount;
		private Button Nhap;
		private Button TiengKeu;
		private Button PhanTich;
		private Label label1;
		private Label label2;
		private Label label3;
	}
}