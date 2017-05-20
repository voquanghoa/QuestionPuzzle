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
    public partial class AddQuestionForm : Form
    {
        public string Question => txtQuestion.Text;

        public string Answer => txtAnswer.Text;
        public AddQuestionForm()
        {
            InitializeComponent();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (txtQuestion.TextLength * txtAnswer.TextLength == 0)
            {
                MessageBox.Show("Invalid question or answer.", "Wrong", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
