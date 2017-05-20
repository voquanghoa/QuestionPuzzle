namespace PrepareQuestions
{
    partial class MakeQuestionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakeQuestionForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btNew = new System.Windows.Forms.ToolStripButton();
            this.btOpen = new System.Windows.Forms.ToolStripButton();
            this.btSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btChangSize = new System.Windows.Forms.ToolStripButton();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btAddQuestion = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btMoveDown = new System.Windows.Forms.Button();
            this.btMoveUp = new System.Windows.Forms.Button();
            this.dialogSave = new System.Windows.Forms.SaveFileDialog();
            this.dialogOpen = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btNew,
            this.btOpen,
            this.btSave,
            this.toolStripSeparator1,
            this.btChangSize});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1216, 42);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btNew
            // 
            this.btNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btNew.Image = global::PrepareQuestions.Properties.Resources._new;
            this.btNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(36, 39);
            this.btNew.Text = "New";
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // btOpen
            // 
            this.btOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btOpen.Image = global::PrepareQuestions.Properties.Resources.open;
            this.btOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(36, 39);
            this.btOpen.Text = "Open";
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // btSave
            // 
            this.btSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btSave.Image = global::PrepareQuestions.Properties.Resources.save32;
            this.btSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(36, 39);
            this.btSave.Text = "Save";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 42);
            // 
            // btChangSize
            // 
            this.btChangSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btChangSize.Image = ((System.Drawing.Image)(resources.GetObject("btChangSize.Image")));
            this.btChangSize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btChangSize.Name = "btChangSize";
            this.btChangSize.Size = new System.Drawing.Size(116, 39);
            this.btChangSize.Text = "Board size : 3x3";
            this.btChangSize.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.btChangSize.Click += new System.EventHandler(this.btChangSize_Click);
            // 
            // dataView
            // 
            this.dataView.AllowUserToAddRows = false;
            this.dataView.AllowUserToDeleteRows = false;
            this.dataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataView.Location = new System.Drawing.Point(3, 3);
            this.dataView.MultiSelect = false;
            this.dataView.Name = "dataView";
            this.dataView.RowTemplate.Height = 24;
            this.dataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataView.Size = new System.Drawing.Size(1186, 459);
            this.dataView.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Question";
            this.Column1.Name = "Column1";
            this.Column1.Width = 400;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Answer";
            this.Column2.Name = "Column2";
            this.Column2.Width = 400;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataView);
            this.panel1.Controls.Add(this.btAddQuestion);
            this.panel1.Controls.Add(this.btDelete);
            this.panel1.Controls.Add(this.btMoveDown);
            this.panel1.Controls.Add(this.btMoveUp);
            this.panel1.Location = new System.Drawing.Point(12, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1192, 506);
            this.panel1.TabIndex = 6;
            this.panel1.Visible = false;
            // 
            // btAddQuestion
            // 
            this.btAddQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAddQuestion.Image = ((System.Drawing.Image)(resources.GetObject("btAddQuestion.Image")));
            this.btAddQuestion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAddQuestion.Location = new System.Drawing.Point(1056, 471);
            this.btAddQuestion.Name = "btAddQuestion";
            this.btAddQuestion.Size = new System.Drawing.Size(136, 35);
            this.btAddQuestion.TabIndex = 4;
            this.btAddQuestion.Text = "Add question";
            this.btAddQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAddQuestion.UseVisualStyleBackColor = true;
            this.btAddQuestion.Click += new System.EventHandler(this.btAddQuestion_Click);
            // 
            // btDelete
            // 
            this.btDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btDelete.Image = ((System.Drawing.Image)(resources.GetObject("btDelete.Image")));
            this.btDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDelete.Location = new System.Drawing.Point(3, 468);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(159, 35);
            this.btDelete.TabIndex = 5;
            this.btDelete.Text = "Delete question";
            this.btDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btMoveDown
            // 
            this.btMoveDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btMoveDown.Image = ((System.Drawing.Image)(resources.GetObject("btMoveDown.Image")));
            this.btMoveDown.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btMoveDown.Location = new System.Drawing.Point(476, 471);
            this.btMoveDown.Name = "btMoveDown";
            this.btMoveDown.Size = new System.Drawing.Size(128, 35);
            this.btMoveDown.TabIndex = 4;
            this.btMoveDown.Text = "Move down";
            this.btMoveDown.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btMoveDown.UseVisualStyleBackColor = true;
            this.btMoveDown.Click += new System.EventHandler(this.btMoveDown_Click);
            // 
            // btMoveUp
            // 
            this.btMoveUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btMoveUp.Image = ((System.Drawing.Image)(resources.GetObject("btMoveUp.Image")));
            this.btMoveUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btMoveUp.Location = new System.Drawing.Point(368, 471);
            this.btMoveUp.Name = "btMoveUp";
            this.btMoveUp.Size = new System.Drawing.Size(102, 35);
            this.btMoveUp.TabIndex = 4;
            this.btMoveUp.Text = "Move up";
            this.btMoveUp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btMoveUp.UseVisualStyleBackColor = true;
            this.btMoveUp.Click += new System.EventHandler(this.btMoveUp_Click);
            // 
            // dialogSave
            // 
            this.dialogSave.Filter = "Json file (*.json)|*.json";
            // 
            // dialogOpen
            // 
            this.dialogOpen.Filter = "Json file(*.json)|*.json";
            // 
            // MakeQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 563);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MakeQuestionForm";
            this.Text = "Make questions";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btNew;
        private System.Windows.Forms.ToolStripButton btOpen;
        private System.Windows.Forms.ToolStripButton btSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btChangSize;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.Button btMoveUp;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btMoveDown;
        private System.Windows.Forms.Button btAddQuestion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.SaveFileDialog dialogSave;
        private System.Windows.Forms.OpenFileDialog dialogOpen;
    }
}

