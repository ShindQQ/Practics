namespace Practic13
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
            this.IsCompleted = new System.Windows.Forms.Button();
            this.End = new System.Windows.Forms.Button();
            this.Collback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IsCompleted
            // 
            this.IsCompleted.Location = new System.Drawing.Point(282, 214);
            this.IsCompleted.Name = "IsCompleted";
            this.IsCompleted.Size = new System.Drawing.Size(75, 23);
            this.IsCompleted.TabIndex = 0;
            this.IsCompleted.Text = "IsCompleted";
            this.IsCompleted.UseVisualStyleBackColor = true;
            this.IsCompleted.Click += new System.EventHandler(this.IsCompleted_Click);
            // 
            // End
            // 
            this.End.Location = new System.Drawing.Point(363, 214);
            this.End.Name = "End";
            this.End.Size = new System.Drawing.Size(75, 23);
            this.End.TabIndex = 1;
            this.End.Text = "End";
            this.End.UseVisualStyleBackColor = true;
            this.End.Click += new System.EventHandler(this.End_Click);
            // 
            // Collback
            // 
            this.Collback.Location = new System.Drawing.Point(444, 214);
            this.Collback.Name = "Collback";
            this.Collback.Size = new System.Drawing.Size(75, 23);
            this.Collback.TabIndex = 2;
            this.Collback.Text = "Collback";
            this.Collback.UseVisualStyleBackColor = true;
            this.Collback.Click += new System.EventHandler(this.Collback_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Collback);
            this.Controls.Add(this.End);
            this.Controls.Add(this.IsCompleted);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button IsCompleted;
        private System.Windows.Forms.Button End;
        private System.Windows.Forms.Button Collback;
    }
}

