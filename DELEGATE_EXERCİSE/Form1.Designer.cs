namespace DELEGATE_EXERCİSE
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bilinmeyenText = new System.Windows.Forms.Label();
            this.karesiText = new System.Windows.Forms.Label();
            this.küpüText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "SAYI GİRİN : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(153, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "HESAPLA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "4X^2+5X+10 :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "SAYININ KARESİ :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "SAYININ  KÜPÜ :";
            // 
            // bilinmeyenText
            // 
            this.bilinmeyenText.AutoSize = true;
            this.bilinmeyenText.Location = new System.Drawing.Point(439, 63);
            this.bilinmeyenText.Name = "bilinmeyenText";
            this.bilinmeyenText.Size = new System.Drawing.Size(76, 16);
            this.bilinmeyenText.TabIndex = 6;
            this.bilinmeyenText.Text = ".......................";
            // 
            // karesiText
            // 
            this.karesiText.AutoSize = true;
            this.karesiText.Location = new System.Drawing.Point(439, 97);
            this.karesiText.Name = "karesiText";
            this.karesiText.Size = new System.Drawing.Size(76, 16);
            this.karesiText.TabIndex = 7;
            this.karesiText.Text = ".......................";
            // 
            // küpüText
            // 
            this.küpüText.AutoSize = true;
            this.küpüText.Location = new System.Drawing.Point(439, 132);
            this.küpüText.Name = "küpüText";
            this.küpüText.Size = new System.Drawing.Size(76, 16);
            this.küpüText.TabIndex = 8;
            this.küpüText.Text = ".......................";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 282);
            this.Controls.Add(this.küpüText);
            this.Controls.Add(this.karesiText);
            this.Controls.Add(this.bilinmeyenText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label bilinmeyenText;
        private System.Windows.Forms.Label karesiText;
        private System.Windows.Forms.Label küpüText;
    }
}

