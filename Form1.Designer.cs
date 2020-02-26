namespace sha256
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
            this.İzleme = new System.Windows.Forms.GroupBox();
            this.lblHash2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblHex2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblInt2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAvg2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTime2 = new System.Windows.Forms.Label();
            this.lblTimex = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.İzleme.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // İzleme
            // 
            this.İzleme.Controls.Add(this.lblHash2);
            this.İzleme.Controls.Add(this.label5);
            this.İzleme.Controls.Add(this.lblHex2);
            this.İzleme.Controls.Add(this.label6);
            this.İzleme.Controls.Add(this.lblInt2);
            this.İzleme.Controls.Add(this.label3);
            this.İzleme.Controls.Add(this.lblAvg2);
            this.İzleme.Controls.Add(this.label4);
            this.İzleme.Controls.Add(this.lblTime2);
            this.İzleme.Controls.Add(this.lblTimex);
            this.İzleme.Location = new System.Drawing.Point(230, 13);
            this.İzleme.Name = "İzleme";
            this.İzleme.Size = new System.Drawing.Size(776, 142);
            this.İzleme.TabIndex = 37;
            this.İzleme.TabStop = false;
            this.İzleme.Text = "İzleme";
            // 
            // lblHash2
            // 
            this.lblHash2.AutoSize = true;
            this.lblHash2.Location = new System.Drawing.Point(159, 108);
            this.lblHash2.MaximumSize = new System.Drawing.Size(2000, 0);
            this.lblHash2.Name = "lblHash2";
            this.lblHash2.Size = new System.Drawing.Size(13, 17);
            this.lblHash2.TabIndex = 23;
            this.lblHash2.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Hash";
            // 
            // lblHex2
            // 
            this.lblHex2.AutoSize = true;
            this.lblHex2.Location = new System.Drawing.Point(159, 91);
            this.lblHex2.MaximumSize = new System.Drawing.Size(2000, 0);
            this.lblHex2.Name = "lblHex2";
            this.lblHex2.Size = new System.Drawing.Size(13, 17);
            this.lblHex2.TabIndex = 21;
            this.lblHex2.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Hex";
            // 
            // lblInt2
            // 
            this.lblInt2.AutoSize = true;
            this.lblInt2.Location = new System.Drawing.Point(162, 43);
            this.lblInt2.Name = "lblInt2";
            this.lblInt2.Size = new System.Drawing.Size(13, 17);
            this.lblInt2.TabIndex = 19;
            this.lblInt2.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Toplam Adet";
            // 
            // lblAvg2
            // 
            this.lblAvg2.AutoSize = true;
            this.lblAvg2.Location = new System.Drawing.Point(162, 60);
            this.lblAvg2.Name = "lblAvg2";
            this.lblAvg2.Size = new System.Drawing.Size(13, 17);
            this.lblAvg2.TabIndex = 17;
            this.lblAvg2.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Ortalama Adet";
            // 
            // lblTime2
            // 
            this.lblTime2.AutoSize = true;
            this.lblTime2.Location = new System.Drawing.Point(162, 25);
            this.lblTime2.Name = "lblTime2";
            this.lblTime2.Size = new System.Drawing.Size(13, 17);
            this.lblTime2.TabIndex = 15;
            this.lblTime2.Text = "-";
            // 
            // lblTimex
            // 
            this.lblTimex.AutoSize = true;
            this.lblTimex.Location = new System.Drawing.Point(23, 25);
            this.lblTimex.Name = "lblTimex";
            this.lblTimex.Size = new System.Drawing.Size(38, 17);
            this.lblTimex.TabIndex = 14;
            this.lblTimex.Text = "Süre";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(21, 91);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "Başla";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "x 1000";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnTest);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 142);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Talep Edilen Adet";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(21, 38);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(92, 22);
            this.txtCount.TabIndex = 35;
            this.txtCount.Text = "1000";
            this.txtCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 189);
            this.Controls.Add(this.İzleme);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.İzleme.ResumeLayout(false);
            this.İzleme.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox İzleme;
        private System.Windows.Forms.Label lblHash2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblHex2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblInt2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAvg2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTime2;
        private System.Windows.Forms.Label lblTimex;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCount;
    }
}

