namespace WindowsFormsApplication1
{
    partial class Form4
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.enter4 = new System.Windows.Forms.Button();
            this.satisNumara = new System.Windows.Forms.TextBox();
            this.satisAdet = new System.Windows.Forms.TextBox();
            this.satisTarih = new System.Windows.Forms.DateTimePicker();
            this.satisOdemeSekli = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri TC Numara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tarih";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ödeme Şekli";
            // 
            // enter4
            // 
            this.enter4.AccessibleName = "enter4";
            this.enter4.Location = new System.Drawing.Point(294, 251);
            this.enter4.Name = "enter4";
            this.enter4.Size = new System.Drawing.Size(75, 23);
            this.enter4.TabIndex = 4;
            this.enter4.Text = "Ekle";
            this.enter4.UseVisualStyleBackColor = true;
            // 
            // satisNumara
            // 
            this.satisNumara.AccessibleName = "SatisNumara";
            this.satisNumara.Location = new System.Drawing.Point(169, 75);
            this.satisNumara.Name = "satisNumara";
            this.satisNumara.Size = new System.Drawing.Size(200, 20);
            this.satisNumara.TabIndex = 5;
            // 
            // satisAdet
            // 
            this.satisAdet.Location = new System.Drawing.Point(169, 113);
            this.satisAdet.Name = "satisAdet";
            this.satisAdet.Size = new System.Drawing.Size(200, 20);
            this.satisAdet.TabIndex = 6;
            // 
            // satisTarih
            // 
            this.satisTarih.Location = new System.Drawing.Point(169, 148);
            this.satisTarih.Name = "satisTarih";
            this.satisTarih.Size = new System.Drawing.Size(200, 20);
            this.satisTarih.TabIndex = 9;
            // 
            // satisOdemeSekli
            // 
            this.satisOdemeSekli.FormattingEnabled = true;
            this.satisOdemeSekli.Items.AddRange(new object[] {
            "Peşin",
            "Kredi kart"});
            this.satisOdemeSekli.Location = new System.Drawing.Point(169, 193);
            this.satisOdemeSekli.Name = "satisOdemeSekli";
            this.satisOdemeSekli.Size = new System.Drawing.Size(200, 21);
            this.satisOdemeSekli.TabIndex = 10;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 395);
            this.Controls.Add(this.satisOdemeSekli);
            this.Controls.Add(this.satisTarih);
            this.Controls.Add(this.satisAdet);
            this.Controls.Add(this.satisNumara);
            this.Controls.Add(this.enter4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button enter4;
        private System.Windows.Forms.TextBox satisNumara;
        private System.Windows.Forms.TextBox satisAdet;
        private System.Windows.Forms.DateTimePicker satisTarih;
        private System.Windows.Forms.ComboBox satisOdemeSekli;
    }
}