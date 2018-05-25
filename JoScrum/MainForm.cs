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
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            materialLabel1.ForeColor = Color.White;
            materialLabel2.ForeColor = Color.White;
            materialLabel3.ForeColor = Color.White;
            materialLabel4.ForeColor = Color.White;
            materialLabel5.ForeColor = Color.Gainsboro;
            panel1.SendToBack();

            JoScrum.UpdateDatabase();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialog == DialogResult.Yes) Application.Exit();
        }

        private void addAStoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStoryForm addStoryForm = new AddStoryForm();
            addStoryForm.ShowDialog();
        }

        private void removeThisStoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripItem menuItem = sender as ToolStripItem;
            ContextMenuStrip owner = menuItem.Owner as ContextMenuStrip;
            TextBox textBox = owner.SourceControl as TextBox;

            JoScrum.RemoveStory(textBox.Name);
        }

        private void addATaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripItem menuItem = sender as ToolStripItem;
            ContextMenuStrip owner = menuItem.Owner as ContextMenuStrip;
            TextBox textBox = owner.SourceControl as TextBox;

            AddTaskForm addTaskForm = new AddTaskForm(textBox.Name);
            addTaskForm.ShowDialog();
        }

        private void removeThisTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripItem menuItem = sender as ToolStripItem;
            ContextMenuStrip owner = menuItem.Owner as ContextMenuStrip;
            TextBox textBox = owner.SourceControl as TextBox;
            Panel panel = textBox.Parent as Panel;

            JoScrum.RemoveTask(panel.Name, textBox.Name);
        }

        private TextBox movingTextBox { get; set; }
        private void moveThisTaskStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripItem menuItem = sender as ToolStripItem;
            TextBox textBox = movingTextBox;
            Panel panel = textBox.Parent as Panel;

            if (menuItem.Text.Contains("Not Started"))
            {
                JoScrum.MoveToTask(panel.Name, textBox.Name, TaskType.NOT_STARTED);
                textBox.BackColor = Color.LightGray;
            }
            else if (menuItem.Text.Contains("In Progress"))
            {
                JoScrum.MoveToTask(panel.Name, textBox.Name, TaskType.IN_PROGRESS);
                textBox.BackColor = Color.Yellow;
            }
            else if (menuItem.Text.Contains("Done"))
            {
                JoScrum.MoveToTask(panel.Name, textBox.Name, TaskType.DONE);
                textBox.BackColor = Color.LimeGreen;
            }
        }

        private void StatusToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            ToolStripItem menuItem = sender as ToolStripItem;
            ContextMenuStrip owner = menuItem.Owner as ContextMenuStrip;
            TextBox textBox = owner.SourceControl as TextBox;
            movingTextBox = textBox;
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripItem menuItem = sender as ToolStripItem;
            ContextMenuStrip owner = menuItem.Owner as ContextMenuStrip;
            TextBox textBox = owner.SourceControl as TextBox;
            Panel panel = textBox.Parent as Panel;

            StoryTask task = JoScrum.GetTask(panel.Name, textBox.Name);
            AddTaskForm addTaskForm = new AddTaskForm(task);
            addTaskForm.ShowDialog();
        }
    }
}
