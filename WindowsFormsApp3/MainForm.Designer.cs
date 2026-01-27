namespace WindowsFormsApp3
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
            this.StudentInfoRichTextBox = new System.Windows.Forms.RichTextBox();
            this.HomosapiensRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StudentInfoRichTextBox
            // 
            this.StudentInfoRichTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.StudentInfoRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.StudentInfoRichTextBox.Name = "StudentInfoRichTextBox";
            this.StudentInfoRichTextBox.Size = new System.Drawing.Size(409, 450);
            this.StudentInfoRichTextBox.TabIndex = 0;
            this.StudentInfoRichTextBox.Text = "";
            // 
            // HomosapiensRichTextBox
            // 
            this.HomosapiensRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomosapiensRichTextBox.Location = new System.Drawing.Point(409, 0);
            this.HomosapiensRichTextBox.Name = "HomosapiensRichTextBox";
            this.HomosapiensRichTextBox.Size = new System.Drawing.Size(391, 450);
            this.HomosapiensRichTextBox.TabIndex = 1;
            this.HomosapiensRichTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Студенты";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(415, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Человек разумный";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HomosapiensRichTextBox);
            this.Controls.Add(this.StudentInfoRichTextBox);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox StudentInfoRichTextBox;
        private System.Windows.Forms.RichTextBox HomosapiensRichTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

