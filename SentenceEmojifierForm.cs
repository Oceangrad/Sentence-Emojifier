using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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

            List<string> sentencePieces = currentText.Split(' ').ToList();

            float percentForOneEmoji = 1 / (float)sentencePieces.Count;
            float chanceToPlaceEmoji = percentForOneEmoji;

            List<string> formattedSentencePieces = new List<string>();

            foreach (string piece in sentencePieces)
            {
                float randomFloat = (float)new Random().NextDouble();
                string currentPiece = piece;

                if(randomFloat <= chanceToPlaceEmoji)
                {
                    currentPiece += EmojiCollection.getRandomEmoji();
                    chanceToPlaceEmoji -= percentForOneEmoji;
                }

                formattedSentencePieces.Add(currentPiece);

                chanceToPlaceEmoji += percentForOneEmoji;
            }

            currentText = string.Join(" ", formattedSentencePieces);

            currentText = currentText.Trim();

            TitleLabel.Text = currentText;
        }

        private void copyToClipboardButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(TitleLabel.Text);
        }
    }
}
