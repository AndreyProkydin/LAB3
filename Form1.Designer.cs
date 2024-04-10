namespace labo3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtArr1 = new System.Windows.Forms.TextBox();
            this.bttnTab1 = new System.Windows.Forms.Button();
            this.lblTab1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bttnTab2 = new System.Windows.Forms.Button();
            this.txtArr2 = new System.Windows.Forms.TextBox();
            this.lblTab2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::labo3.Properties.Resources.Снимок_экрана_2024_04_09_180540;
            this.pictureBox1.Location = new System.Drawing.Point(46, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(689, 138);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 418);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lblTab1);
            this.tabPage1.Controls.Add(this.bttnTab1);
            this.tabPage1.Controls.Add(this.txtArr1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 392);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Завдання 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.lblTab2);
            this.tabPage2.Controls.Add(this.txtArr2);
            this.tabPage2.Controls.Add(this.bttnTab2);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 392);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Завдання 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtArr1
            // 
            this.txtArr1.Location = new System.Drawing.Point(169, 213);
            this.txtArr1.Name = "txtArr1";
            this.txtArr1.Size = new System.Drawing.Size(100, 20);
            this.txtArr1.TabIndex = 1;
            // 
            // bttnTab1
            // 
            this.bttnTab1.Location = new System.Drawing.Point(46, 278);
            this.bttnTab1.Name = "bttnTab1";
            this.bttnTab1.Size = new System.Drawing.Size(75, 23);
            this.bttnTab1.TabIndex = 2;
            this.bttnTab1.Text = "Ok";
            this.bttnTab1.UseVisualStyleBackColor = true;
            this.bttnTab1.Click += new System.EventHandler(this.bttnTab1_Click);
            // 
            // lblTab1
            // 
            this.lblTab1.AutoSize = true;
            this.lblTab1.Location = new System.Drawing.Point(186, 283);
            this.lblTab1.Name = "lblTab1";
            this.lblTab1.Size = new System.Drawing.Size(0, 13);
            this.lblTab1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введіть масив";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::labo3.Properties.Resources.Снимок_экрана_2024_04_09_180540;
            this.pictureBox2.Location = new System.Drawing.Point(21, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(719, 146);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // bttnTab2
            // 
            this.bttnTab2.Location = new System.Drawing.Point(21, 280);
            this.bttnTab2.Name = "bttnTab2";
            this.bttnTab2.Size = new System.Drawing.Size(75, 23);
            this.bttnTab2.TabIndex = 1;
            this.bttnTab2.Text = "Ok";
            this.bttnTab2.UseVisualStyleBackColor = true;
            this.bttnTab2.Click += new System.EventHandler(this.bttnTab2_Click);
            // 
            // txtArr2
            // 
            this.txtArr2.Location = new System.Drawing.Point(260, 215);
            this.txtArr2.Name = "txtArr2";
            this.txtArr2.Size = new System.Drawing.Size(100, 20);
            this.txtArr2.TabIndex = 2;
            // 
            // lblTab2
            // 
            this.lblTab2.AutoSize = true;
            this.lblTab2.Location = new System.Drawing.Point(162, 285);
            this.lblTab2.Name = "lblTab2";
            this.lblTab2.Size = new System.Drawing.Size(0, 13);
            this.lblTab2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введіть масив, числа масиву через проіл";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblTab1;
        private System.Windows.Forms.Button bttnTab1;
        private System.Windows.Forms.TextBox txtArr1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTab2;
        private System.Windows.Forms.TextBox txtArr2;
        private System.Windows.Forms.Button bttnTab2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
    }
}

