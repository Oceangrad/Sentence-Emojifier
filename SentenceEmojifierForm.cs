using System;
using System.Windows.Forms;
using EmojifyLib;

namespace Sentence_Emojifier
{
    public partial class SentenceEmojifierForm : Form
    {
        public SentenceEmojifierForm()
        {
            InitializeComponent();
        }

        private void EmojifyButton_Click(object sender, EventArgs e)
        {
            string currentText = TextArea.Text.Trim();

            if (clearCheckBox.Checked)
                TextArea.Text = "";

            if (currentText.Length < 1)
                return;

            currentText = Emojify.getEmojifiedString(currentText);

            currentText = currentText.Trim();

            TitleLabel.Text = currentText;
        }

        private void copyToClipboardButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(TitleLabel.Text);
        }
    }
}
