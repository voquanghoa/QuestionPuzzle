using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrepareQuestions
{
    public partial class BoardSizeForm : Form
    {
        private int colCount;

        public int ColCount
        {
            get => colCount;
            set
            {
                colCount = value;
                txtColCount.Text = value + string.Empty;
            }
        }

        private int rowCount;

        public int RowCount
        {
            get => rowCount;
            set
            {
                rowCount = value;
                txtRowCount.Text = value + string.Empty;
            }
           
        }

        public BoardSizeForm()
        {
            InitializeComponent();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtColCount.Text, out int col) && col > 2)
            {
                if (int.TryParse(txtRowCount.Text, out int row) && row > 2)
                {
                    RowCount = row;
                    ColCount = col;
                    DialogResult = DialogResult.OK;
                    Close();
                    return;
                }
            }

            MessageBox.Show("Invalid row count or column count.", "Wrong", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
        }
    }
}
