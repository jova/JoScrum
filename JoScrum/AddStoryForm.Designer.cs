namespace JoScrum
{
    partial class AddStoryForm
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
            this.txtStory = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnAddStory = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // txtStory
            // 
            this.txtStory.Depth = 0;
            this.txtStory.ForeColor = System.Drawing.Color.White;
            this.txtStory.Hint = "";
            this.txtStory.Location = new System.Drawing.Point(66, 30);
            this.txtStory.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtStory.Name = "txtStory";
            this.txtStory.PasswordChar = '\0';
            this.txtStory.SelectedText = "";
            this.txtStory.SelectionLength = 0;
            this.txtStory.SelectionStart = 0;
            this.txtStory.Size = new System.Drawing.Size(249, 23);
            this.txtStory.TabIndex = 0;
            this.txtStory.UseSystemPasswordChar = false;
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
            this.materialLabel1.Size = new System.Drawing.Size(48, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Story:";
            // 
            // btnAddStory
            // 
            this.btnAddStory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStory.Depth = 0;
            this.btnAddStory.Location = new System.Drawing.Point(321, 30);
            this.btnAddStory.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddStory.Name = "btnAddStory";
            this.btnAddStory.Primary = true;
            this.btnAddStory.Size = new System.Drawing.Size(115, 23);
            this.btnAddStory.TabIndex = 2;
            this.btnAddStory.Text = "Add Story";
            this.btnAddStory.UseVisualStyleBackColor = true;
            this.btnAddStory.Click += new System.EventHandler(this.btnAddStory_Click);
            // 
            // AddStoryForm
            // 
            this.AcceptButton = this.btnAddStory;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 62);
            this.Controls.Add(this.btnAddStory);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtStory);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(448, 62);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(448, 62);
            this.Name = "AddStoryForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AddStoryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtStory;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton btnAddStory;
    }
}