
namespace TeseractProb
{
    partial class TsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TsForm));
            this.picture = new System.Windows.Forms.PictureBox();
            this.AddImage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SaveText = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.readyText = new System.Windows.Forms.ListBox();
            this.clearText = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(12, 12);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(258, 99);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // AddImage
            // 
            this.AddImage.Location = new System.Drawing.Point(276, 12);
            this.AddImage.Name = "AddImage";
            this.AddImage.Size = new System.Drawing.Size(122, 29);
            this.AddImage.TabIndex = 1;
            this.AddImage.Text = "Добавить картинку";
            this.AddImage.UseVisualStyleBackColor = true;
            this.AddImage.Click += new System.EventHandler(this.AddImage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Распознаный текст";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(276, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Удалить картинку";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SaveText
            // 
            this.SaveText.Location = new System.Drawing.Point(276, 206);
            this.SaveText.Name = "SaveText";
            this.SaveText.Size = new System.Drawing.Size(122, 29);
            this.SaveText.TabIndex = 5;
            this.SaveText.Text = "Сохранить";
            this.SaveText.UseVisualStyleBackColor = true;
            this.SaveText.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(276, 241);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 29);
            this.button3.TabIndex = 6;
            this.button3.Text = "Открыть";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // readyText
            // 
            this.readyText.FormattingEnabled = true;
            this.readyText.Location = new System.Drawing.Point(16, 316);
            this.readyText.Name = "readyText";
            this.readyText.Size = new System.Drawing.Size(382, 121);
            this.readyText.TabIndex = 8;
            // 
            // clearText
            // 
            this.clearText.Location = new System.Drawing.Point(276, 276);
            this.clearText.Name = "clearText";
            this.clearText.Size = new System.Drawing.Size(122, 29);
            this.clearText.TabIndex = 9;
            this.clearText.Text = "Отчистить";
            this.clearText.UseVisualStyleBackColor = true;
            this.clearText.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // TsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 456);
            this.Controls.Add(this.clearText);
            this.Controls.Add(this.readyText);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.SaveText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddImage);
            this.Controls.Add(this.picture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TsForm";
            this.Text = "TesseractProb";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button AddImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SaveText;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox readyText;
        private System.Windows.Forms.Button clearText;
    }
}

