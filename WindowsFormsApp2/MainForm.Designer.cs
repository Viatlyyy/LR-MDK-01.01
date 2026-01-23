namespace WindowsFormsApp2
{
    partial class MainForm
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
            this.st1label = new System.Windows.Forms.Label();
            this.st2label = new System.Windows.Forms.Label();
            this.StudentNameListBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureArea = new System.Windows.Forms.PictureBox();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.AvgBallLabel = new System.Windows.Forms.Label();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureArea)).BeginInit();
            this.SuspendLayout();
            // 
            // st1label
            // 
            this.st1label.AutoSize = true;
            this.st1label.Location = new System.Drawing.Point(266, 124);
            this.st1label.Name = "st1label";
            this.st1label.Size = new System.Drawing.Size(35, 13);
            this.st1label.TabIndex = 0;
            this.st1label.Text = "label1";
            // 
            // st2label
            // 
            this.st2label.AutoSize = true;
            this.st2label.Location = new System.Drawing.Point(266, 182);
            this.st2label.Name = "st2label";
            this.st2label.Size = new System.Drawing.Size(35, 13);
            this.st2label.TabIndex = 1;
            this.st2label.Text = "label1";
            // 
            // StudentNameListBox
            // 
            this.StudentNameListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.StudentNameListBox.FormattingEnabled = true;
            this.StudentNameListBox.Location = new System.Drawing.Point(0, 0);
            this.StudentNameListBox.Name = "StudentNameListBox";
            this.StudentNameListBox.Size = new System.Drawing.Size(155, 450);
            this.StudentNameListBox.TabIndex = 2;
            this.StudentNameListBox.SelectedIndexChanged += new System.EventHandler(this.StudentNameListBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.NumberLabel);
            this.panel1.Controls.Add(this.AvgBallLabel);
            this.panel1.Controls.Add(this.AgeLabel);
            this.panel1.Controls.Add(this.pictureArea);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(155, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 450);
            this.panel1.TabIndex = 3;
            // 
            // pictureArea
            // 
            this.pictureArea.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureArea.Location = new System.Drawing.Point(360, 0);
            this.pictureArea.Name = "pictureArea";
            this.pictureArea.Size = new System.Drawing.Size(285, 450);
            this.pictureArea.TabIndex = 0;
            this.pictureArea.TabStop = false;
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AgeLabel.Location = new System.Drawing.Point(178, 40);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(53, 21);
            this.AgeLabel.TabIndex = 1;
            this.AgeLabel.Text = "label1";
            // 
            // AvgBallLabel
            // 
            this.AvgBallLabel.AutoSize = true;
            this.AvgBallLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AvgBallLabel.Location = new System.Drawing.Point(178, 74);
            this.AvgBallLabel.Name = "AvgBallLabel";
            this.AvgBallLabel.Size = new System.Drawing.Size(53, 21);
            this.AvgBallLabel.TabIndex = 2;
            this.AvgBallLabel.Text = "label1";
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberLabel.Location = new System.Drawing.Point(178, 105);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(53, 21);
            this.NumberLabel.TabIndex = 3;
            this.NumberLabel.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(67, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Возраст:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(20, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Средний балл:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(20, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Номер билета:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.StudentNameListBox);
            this.Controls.Add(this.st2label);
            this.Controls.Add(this.st1label);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label st1label;
        private System.Windows.Forms.Label st2label;
        private System.Windows.Forms.ListBox StudentNameListBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureArea;
        private System.Windows.Forms.Label NumberLabel;
        private System.Windows.Forms.Label AvgBallLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

