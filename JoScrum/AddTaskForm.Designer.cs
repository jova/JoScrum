namespace JoScrum
{
    partial class AddTaskForm
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtAssignedTo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtTask = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtDate = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.labelDate = new MaterialSkin.Controls.MaterialLabel();
            this.btnAddTask = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 30);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(97, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Assigned To:";
            // 
            // txtAssignedTo
            // 
            this.txtAssignedTo.Depth = 0;
            this.txtAssignedTo.ForeColor = System.Drawing.Color.White;
            this.txtAssignedTo.Hint = "";
            this.txtAssignedTo.Location = new System.Drawing.Point(115, 30);
            this.txtAssignedTo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAssignedTo.Name = "txtAssignedTo";
            this.txtAssignedTo.PasswordChar = '\0';
            this.txtAssignedTo.SelectedText = "";
            this.txtAssignedTo.SelectionLength = 0;
            this.txtAssignedTo.SelectionStart = 0;
            this.txtAssignedTo.Size = new System.Drawing.Size(215, 23);
            this.txtAssignedTo.TabIndex = 0;
            this.txtAssignedTo.UseSystemPasswordChar = false;
            // 
            // txtTask
            // 
            this.txtTask.Depth = 0;
            this.txtTask.ForeColor = System.Drawing.Color.White;
            this.txtTask.Hint = "";
            this.txtTask.Location = new System.Drawing.Point(66, 72);
            this.txtTask.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTask.Name = "txtTask";
            this.txtTask.PasswordChar = '\0';
            this.txtTask.SelectedText = "";
            this.txtTask.SelectionLength = 0;
            this.txtTask.SelectionStart = 0;
            this.txtTask.Size = new System.Drawing.Size(264, 23);
            this.txtTask.TabIndex = 1;
            this.txtTask.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(12, 72);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(46, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Task:";
            // 
            // txtDate
            // 
            this.txtDate.Depth = 0;
            this.txtDate.ForeColor = System.Drawing.Color.White;
            this.txtDate.Hint = "";
            this.txtDate.Location = new System.Drawing.Point(66, 101);
            this.txtDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDate.Name = "txtDate";
            this.txtDate.PasswordChar = '\0';
            this.txtDate.SelectedText = "";
            this.txtDate.SelectionLength = 0;
            this.txtDate.SelectionStart = 0;
            this.txtDate.Size = new System.Drawing.Size(264, 23);
            this.txtDate.TabIndex = 2;
            this.txtDate.UseSystemPasswordChar = false;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDate.Depth = 0;
            this.labelDate.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelDate.Location = new System.Drawing.Point(12, 101);
            this.labelDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(44, 19);
            this.labelDate.TabIndex = 4;
            this.labelDate.Text = "Date:";
            // 
            // btnAddTask
            // 
            this.btnAddTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTask.Depth = 0;
            this.btnAddTask.Location = new System.Drawing.Point(66, 130);
            this.btnAddTask.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Primary = true;
            this.btnAddTask.Size = new System.Drawing.Size(264, 23);
            this.btnAddTask.TabIndex = 3;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // AddTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 167);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtTask);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtAssignedTo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddTaskForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AddTaskForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAssignedTo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTask;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDate;
        private MaterialSkin.Controls.MaterialLabel labelDate;
        private MaterialSkin.Controls.MaterialRaisedButton btnAddTask;
    }
}