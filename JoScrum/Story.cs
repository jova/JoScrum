using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoScrum
{
    public class Story
    {
        public Guid Id { get; set; }
        public List<StoryTask> Tasks = new List<StoryTask>();
        public string Text { get; set; }
        public string StoryBoxName { get; set; }

        public Story()
        {

        }

        public Story(string text, string storyBoxName)
        {
            Text = text;
            StoryBoxName = storyBoxName;
            addStoryBox();
            updateDatabaseTasks();
        }

        public void AddTask(string assignedTo, string date, string text)
        {
            StoryTask task = new StoryTask(assignedTo, date, text, StoryBoxName, string.Empty, TaskType.NOT_STARTED);

            using (LiteDatabase db = new LiteDatabase(JoScrum.DB_PATH))
            {
                var tasks = db.GetCollection<StoryTask>("StoryTask");

                tasks.Insert(task);
            }

            Tasks.Add(task);
        }

        private void addStoryBox()
        {
            TextBox storyBox = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                Text = Text,
                Width = 130,
                Height = 75,
                Location = new System.Drawing.Point(10, 80 * (JoScrum.Stories.Count + 1)),
                ContextMenuStrip = Program.MainForm.storyMenu,
            };

            if (string.IsNullOrEmpty(StoryBoxName))
            {
                StoryBoxName = "txtStoryBox-" + (JoScrum.Stories.Count + 1);
            }

            storyBox.Name = StoryBoxName;


            FlowLayoutPanel panel = new FlowLayoutPanel() { Name = StoryBoxName + "_NotStarted", Location = new System.Drawing.Point(Program.MainForm.line1.Location.X + 5, storyBox.Location.Y), Size = new System.Drawing.Size(210, 75), BackColor = System.Drawing.Color.Transparent };
            FlowLayoutPanel panel2 = new FlowLayoutPanel() { Name = StoryBoxName + "_InProgress", Location = new System.Drawing.Point(Program.MainForm.line2.Location.X + 10, storyBox.Location.Y), Size = new System.Drawing.Size(210, 75), BackColor = System.Drawing.Color.Transparent };
            FlowLayoutPanel panel3 = new FlowLayoutPanel() { Name = StoryBoxName + "_Done", Location = new System.Drawing.Point(Program.MainForm.line3.Location.X + 10, storyBox.Location.Y), Size = new System.Drawing.Size(210, 75), BackColor = System.Drawing.Color.Transparent };

            if ((storyBox.Location.Y + storyBox.Height) > Program.MainForm.Size.Height)
            {
                Program.MainForm.Size = new System.Drawing.Size(Program.MainForm.Size.Width, Program.MainForm.Height + 75);
                Program.MainForm.line1.Size = Program.MainForm.line2.Size = Program.MainForm.line3.Size = new System.Drawing.Size(Program.MainForm.line1.Size.Width, Program.MainForm.Height + 75);
                Program.MainForm.panel1.Size = new System.Drawing.Size(Program.MainForm.panel1.Size.Width, Program.MainForm.Height + 75);
            }

            Program.MainForm.Controls.Add(storyBox);
            Program.MainForm.Controls.Add(panel);
            Program.MainForm.Controls.Add(panel2);
            Program.MainForm.Controls.Add(panel3);

            Program.MainForm.panel1.SendToBack();
            storyBox.BringToFront();
        }

        private void updateDatabaseTasks()
        {
            List<StoryTask> tempTasks = new List<StoryTask>();

            using (LiteDatabase db = new LiteDatabase(JoScrum.DB_PATH))
            {
                var stories = db.GetCollection<StoryTask>("StoryTask");

                tempTasks = stories.Find(x => x.StoryBoxName == StoryBoxName).ToList();
            }

            foreach (StoryTask task in tempTasks)
            {
                StoryTask newTask = new StoryTask(task.AssignedTo, task.Date, task.Text, StoryBoxName, task.Name, task.Type);
                Tasks.Add(newTask);
            }
        }
    }
}
