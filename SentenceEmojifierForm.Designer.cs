namespace Sentence_Emojifier
{
    partial class SentenceEmojifierForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SentenceEmojifierForm));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.EmojifyButton = new System.Windows.Forms.Button();
            this.TextArea = new System.Windows.Forms.TextBox();
            this.clearCheckBox = new System.Windows.Forms.CheckBox();
            this.copyToClipboardButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLabel.Location = new System.Drawing.Point(30, 81);
            this.TitleLabel.MaximumSize = new System.Drawing.Size(1000, 50);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(600, 50);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Put any sentence in";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // EmojifyButton
            // 
            this.EmojifyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmojifyButton.Location = new System.Drawing.Point(411, 146);
            this.EmojifyButton.Name = "EmojifyButton";
            this.EmojifyButton.Size = new System.Drawing.Size(105, 40);
            this.EmojifyButton.TabIndex = 1;
            this.EmojifyButton.Text = "Emojify!";
            this.EmojifyButton.UseVisualStyleBackColor = true;
            this.EmojifyButton.Click += new System.EventHandler(this.EmojifyButton_Click);
            // 
            // TextArea
            // 
            this.TextArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextArea.Location = new System.Drawing.Point(144, 153);
            this.TextArea.Name = "TextArea";
            this.TextArea.Size = new System.Drawing.Size(246, 27);
            this.TextArea.TabIndex = 2;
            // 
            // clearCheckBox
            // 
            this.clearCheckBox.AutoSize = true;
            this.clearCheckBox.Checked = true;
            this.clearCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.clearCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearCheckBox.Location = new System.Drawing.Point(297, 203);
            this.clearCheckBox.Name = "clearCheckBox";
            this.clearCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.clearCheckBox.Size = new System.Drawing.Size(219, 21);
            this.clearCheckBox.TabIndex = 3;
            this.clearCheckBox.Text = "Clear text area after emojifying";
            this.clearCheckBox.UseVisualStyleBackColor = true;
            // 
            // copyToClipboardButton
            // 
            this.copyToClipboardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.copyToClipboardButton.Location = new System.Drawing.Point(244, 258);
            this.copyToClipboardButton.Name = "copyToClipboardButton";
            this.copyToClipboardButton.Size = new System.Drawing.Size(173, 40);
            this.copyToClipboardButton.TabIndex = 4;
            this.copyToClipboardButton.Text = "Copy to Clipboard";
            this.copyToClipboardButton.UseVisualStyleBackColor = true;
            this.copyToClipboardButton.Click += new System.EventHandler(this.copyToClipboardButton_Click);
            // 
            // SentenceEmojifierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 450);
            this.Controls.Add(this.copyToClipboardButton);
            this.Controls.Add(this.clearCheckBox);
            this.Controls.Add(this.TextArea);
            this.Controls.Add(this.EmojifyButton);
            this.Controls.Add(this.TitleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SentenceEmojifierForm";
            this.Text = "Sentence emojifier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button EmojifyButton;
        private System.Windows.Forms.TextBox TextArea;
        private System.Windows.Forms.CheckBox clearCheckBox;
        private System.Windows.Forms.Button copyToClipboardButton;
    }
}

