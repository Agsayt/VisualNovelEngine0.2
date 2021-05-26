namespace GameQuest
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
            this.mainPicture = new System.Windows.Forms.PictureBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.mainPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPicture
            // 
            this.mainPicture.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mainPicture.Location = new System.Drawing.Point(12, 12);
            this.mainPicture.Name = "mainPicture";
            this.mainPicture.Size = new System.Drawing.Size(720, 480);
            this.mainPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainPicture.TabIndex = 0;
            this.mainPicture.TabStop = false;
            // 
            // outputTextBox
            // 
            this.outputTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.outputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputTextBox.Location = new System.Drawing.Point(12, 498);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputTextBox.ShortcutsEnabled = false;
            this.outputTextBox.Size = new System.Drawing.Size(720, 105);
            this.outputTextBox.TabIndex = 1;
            this.outputTextBox.TabStop = false;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mainPanel.Location = new System.Drawing.Point(12, 609);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(720, 119);
            this.mainPanel.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 733);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.mainPicture);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mainPicture;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Panel mainPanel;
    }
}

