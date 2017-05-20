using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishPuzzle
{
    public partial class PuzzleBoard : UserControl
    {
        private const int BorderSize = 6;

        private Size boardSize = new Size(3, 3);

        public Size BoardSize
        {
            set
            {
                boardSize = value;
                Repaint();
            }
            get => boardSize;
        }

        public PuzzleBoard()
        {
            InitializeComponent();
            Repaint();
        }
        
        private void Repaint()
        {
            Controls.Clear();

            var buttonWidth = (this.Width - (boardSize.Width + 1) * BorderSize) / boardSize.Width;
            var buttonHeight = (this.Height - (boardSize.Height + 1) * BorderSize) / boardSize.Height;

            
            var buttonTop = BorderSize;
            for (var row = 0; row < boardSize.Height; row++)
            {
                var buttonLeft = BorderSize;
                for (var col = 0; col < boardSize.Width; col++)
                {
                    var button = new PuzzleButton()
                    {
                        Width = buttonWidth,
                        Height = buttonHeight
                    };
                    this.Controls.Add(button);

                    button.Left = buttonLeft;
                    button.Top = buttonTop;
                    button.Click += ButtonOnClick;
                    buttonLeft += buttonWidth + BorderSize;
                }

                buttonTop += buttonHeight + BorderSize;
            }
        }

        private void ButtonOnClick(object sender, EventArgs eventArgs)
        {
            foreach (var puzzleButton in Controls.OfType<PuzzleButton>())
            {
                puzzleButton.Activated = puzzleButton == sender;
            }

            ((PuzzleButton)sender).State = PuzzleButton.PuzzleState.ShowO;
            
        }

        private void PuzzleBoard_SizeChanged(object sender, EventArgs e)
        {
            Repaint();
        }
    }
}
