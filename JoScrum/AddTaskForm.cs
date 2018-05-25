using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace JoScrum
{
    public partial class AddTaskForm : MaterialForm
    {
        private string storyName { get; set; }

        public AddTaskForm(string storyText)
        {
            InitializeComponent();

            this.storyName = storyText;
        }

        public AddTaskForm(StoryTask task)
        {
            InitializeComponent();

            btnAddTask.Text = "Close";
            txtAssignedTo.Text = task.AssignedTo;
            txtDate.Text = task.Date;
            txtTask.Text = task.Text;

            txtAssignedTo.Enabled = false;
            txtDate.Enabled = false;
            txtTask.Enabled = false;
        }

        private void AddTaskForm_Load(object sender, EventArgs e)
        {
            materialLabel1.ForeColor = Color.White;
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (btnAddTask.Text == "Close")
            {
                this.Hide();
                return;
            }

            JoScrum.Stories.Find(x => x.StoryBoxName == storyName).AddTask(txtAssignedTo.Text, txtDate.Text, txtTask.Text);
            this.Hide();
        }
    }
}
