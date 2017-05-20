using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishPuzzle
{
    public partial class PuzzleButton : UserControl
    {
        public Image ShowOImg = Image.FromFile("o_blue.png");
        public Image ShowXImg = Image.FromFile("x_red.png");
        private const int PuzzlePadding = 5;
        private const int BorderSize = 6;
        public enum PuzzleState
        {
            None,
            ShowO,
            ShowX
        }

        private PuzzleState state;

        public PuzzleState State
        {
            get=>state;
            set
            {
                state = value;
                Invalidate();
            }
            
        }

        private bool activated;
        public bool Activated
        {
            get => activated;
            set
            {
                activated = value;
                Invalidate();
            }
        }

        public PuzzleButton()
        {
            InitializeComponent();
            Activated = false;
            State = PuzzleState.None;
        }
        
        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;

            if (activated)
            {                
                g.FillRectangle(new SolidBrush(Color.ForestGreen),0,0,Width,Height);
                g.FillRectangle(new SolidBrush(Color.White), BorderSize, BorderSize, Width - 2* BorderSize, Height - 2 * BorderSize);
            }

            var rectange = new Rectangle(PuzzlePadding, PuzzlePadding, Width- PuzzlePadding * 2, Height- PuzzlePadding * 2);

            switch (State)
            {
                case PuzzleState.ShowO:
                    g.DrawImage(ShowOImg, rectange);
                    break;
                case PuzzleState.ShowX:
                    g.DrawImage(ShowXImg, rectange);
                    break;
            }
            g.Dispose();
        }
    }
}
