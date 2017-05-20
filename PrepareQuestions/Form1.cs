using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace PrepareQuestions
{
    public partial class MakeQuestionForm : Form
    {
        private int rowCount = 3;
        private int colCount = 3;
        private string path = string.Empty;
        public MakeQuestionForm()
        {
            InitializeComponent();
        }

        private void btChangSize_Click(object sender, EventArgs e)
        {
            var form = new BoardSizeForm
            {
                ColCount = colCount,
                RowCount = rowCount
            };

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                rowCount = form.RowCount;
                colCount = form.ColCount;
                btChangSize.Text = $"Board size {rowCount}x{colCount}";
            }
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            path = "";
            dataView.Rows.Clear();
            Text = "Make questions - *";
            rowCount = colCount = 3;
            btChangSize.Text = $"Board size {rowCount}x{colCount}";
        }

        private void btAddQuestion_Click(object sender, EventArgs e)
        {
            var form = new AddQuestionForm();

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                AddRow(form.Question, form.Answer);
            }
        }

        private void AddRow(string question, string answer)
        {
            var rowId = dataView.Rows.Add(question,answer);
            dataView.Rows[rowId].HeaderCell.Value = string.Empty + (rowId + 1);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dataView.SelectedRows.Count > 0)
            {
                dataView.Rows.Remove(dataView.SelectedRows[0]);
            }
        }

        private void SwapRow(int index1, int index2)
        {
            if (index1 >= 0 && index2 >= 0 && index1 < dataView.RowCount && index2 < dataView.RowCount && index1 != index2)
            {
                var row1 = dataView.Rows[index1];
                var row2 = dataView.Rows[index2];

                for (var cellId = 0; cellId < dataView.ColumnCount; cellId++)
                {
                    var obj = row1.Cells[cellId].Value;
                    row1.Cells[cellId].Value = row2.Cells[cellId].Value;
                    row2.Cells[cellId].Value = obj;
                }

                row2.Selected = true;
            }
        }

        private int GetSelectIndex()
        {
            if (dataView.SelectedRows.Count > 0)
            {
                return dataView.Rows.IndexOf(dataView.SelectedRows[0]);
            }
            return -1;
        }
        private void btMoveUp_Click(object sender, EventArgs e)
        {
            var selected = GetSelectIndex();
            SwapRow(selected, selected - 1);
        }

        private void btMoveDown_Click(object sender, EventArgs e)
        {
            var selected = GetSelectIndex();
            SwapRow(selected, selected + 1);
        }

        private void SaveFile()
        {
            var content = new Content()
            {
                Column = colCount,
                Row = rowCount,
                Questions = dataView.Rows.Cast<DataGridViewRow>()
                    .Select(x => new Question()
                    {
                        Title = x.Cells[0].Value + String.Empty,
                        Answer = x.Cells[1].Value + String.Empty,
                    })
                    .ToList()
            };

            File.WriteAllText(path, JsonConvert.SerializeObject(content));
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (panel1.Visible)
            {
                if (string.IsNullOrEmpty(path))
                {
                    if (dialogSave.ShowDialog(this) == DialogResult.OK)
                    {
                        path = dialogSave.FileName;
                        Text = "Make questions - " + path;
                        SaveFile();
                    }
                }
                else
                {
                    SaveFile();
                }
            }
        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            if (dialogOpen.ShowDialog(this) == DialogResult.OK)
            {
                var selectPath = dialogOpen.FileName;
                Text = "Make questions - " + path;

                try
                {
                    var content = JsonConvert.DeserializeObject<Content>(File.ReadAllText(selectPath));

                    dataView.Rows.Clear();
                    foreach (var question in content.Questions)
                    {
                        AddRow(question.Title, question.Answer);
                    }

                    btChangSize.Text = $"Board size {content.Row}x{content.Column}";
                    this.path = selectPath;
                    this.colCount = content.Column;
                    this.rowCount = content.Row;
                    panel1.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }
    }
}
