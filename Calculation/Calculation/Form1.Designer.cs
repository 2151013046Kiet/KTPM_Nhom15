namespace Calculator
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
            this.Cong = new System.Windows.Forms.Button();
            this.Tru = new System.Windows.Forms.Button();
            this.Nhan = new System.Windows.Forms.Button();
            this.Chia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_1 = new System.Windows.Forms.TextBox();
            this.txt_2 = new System.Windows.Forms.TextBox();
            this.txt_kq = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Cong
            // 
            this.Cong.Location = new System.Drawing.Point(86, 299);
            this.Cong.Name = "Cong";
            this.Cong.Size = new System.Drawing.Size(75, 23);
            this.Cong.TabIndex = 0;
            this.Cong.Text = "Cộng";
            this.Cong.UseVisualStyleBackColor = true;
            this.Cong.Click += new System.EventHandler(this.Cong_Click);
            // 
            // Tru
            // 
            this.Tru.Location = new System.Drawing.Point(225, 299);
            this.Tru.Name = "Tru";
            this.Tru.Size = new System.Drawing.Size(75, 23);
            this.Tru.TabIndex = 1;
            this.Tru.Text = "Trừ";
            this.Tru.UseVisualStyleBackColor = true;
            this.Tru.Click += new System.EventHandler(this.Tru_Click);
            // 
            // Nhan
            // 
            this.Nhan.Location = new System.Drawing.Point(364, 299);
            this.Nhan.Name = "Nhan";
            this.Nhan.Size = new System.Drawing.Size(75, 23);
            this.Nhan.TabIndex = 2;
            this.Nhan.Text = "Nhân";
            this.Nhan.UseVisualStyleBackColor = true;
            this.Nhan.Click += new System.EventHandler(this.Nhan_Click);
            // 
            // Chia
            // 
            this.Chia.Location = new System.Drawing.Point(503, 299);
            this.Chia.Name = "Chia";
            this.Chia.Size = new System.Drawing.Size(75, 23);
            this.Chia.TabIndex = 3;
            this.Chia.Text = "Chia";
            this.Chia.UseVisualStyleBackColor = true;
            this.Chia.Click += new System.EventHandler(this.Chia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Số 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Số 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "KQ";
            // 
            // txt_1
            // 
            this.txt_1.Location = new System.Drawing.Point(200, 97);
            this.txt_1.Name = "txt_1";
            this.txt_1.Size = new System.Drawing.Size(100, 20);
            this.txt_1.TabIndex = 7;
            // 
            // txt_2
            // 
            this.txt_2.Location = new System.Drawing.Point(200, 166);
            this.txt_2.Name = "txt_2";
            this.txt_2.Size = new System.Drawing.Size(100, 20);
            this.txt_2.TabIndex = 8;
            // 
            // txt_kq
            // 
            this.txt_kq.Location = new System.Drawing.Point(200, 229);
            this.txt_kq.Name = "txt_kq";
            this.txt_kq.Size = new System.Drawing.Size(100, 20);
            this.txt_kq.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 437);
            this.Controls.Add(this.txt_kq);
            this.Controls.Add(this.txt_2);
            this.Controls.Add(this.txt_1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Chia);
            this.Controls.Add(this.Nhan);
            this.Controls.Add(this.Tru);
            this.Controls.Add(this.Cong);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cong;
        private System.Windows.Forms.Button Tru;
        private System.Windows.Forms.Button Nhan;
        private System.Windows.Forms.Button Chia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_1;
        private System.Windows.Forms.TextBox txt_2;
        private System.Windows.Forms.TextBox txt_kq;
    }
}

