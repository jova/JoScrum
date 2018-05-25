using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoScrum
{
    public class StoryTask
    {
        public Guid Id { get; set; }
        public string StoryBoxName { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public string AssignedTo { get; set; }
        public string Date { get; set; }
        public TaskType Type { get; set; }

        public StoryTask()
        {

        }
        public StoryTask(string assignedTo, string date, string text, string storyBoxName, string taskName, TaskType taskType)
        {
            AssignedTo = assignedTo;
            Date = date;
            Text = text;
            StoryBoxName = storyBoxName;
            Type = taskType;
            Name = taskName;
            addTaskBox();
        }

        private void addTaskBox()
        {
            TextBox taskBox = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                Text = Text,
                Width = 60,
                Height = 20,
                Name = Name,
                ContextMenuStrip = Program.MainForm.taskMenu,
            };

            
            if (string.IsNullOrEmpty(Name))
            {
                Name = StoryBoxName + "-task-" + (JoScrum.Stories.Find(x => x.StoryBoxName == StoryBoxName) == null ? 0 : JoScrum.Stories.Find(x => x.StoryBoxName == StoryBoxName).Tasks.Count);
            }

            taskBox.Name = Name;

            if (Type == TaskType.NOT_STARTED)
            {
                Program.MainForm.Controls.Find(StoryBoxName + "_NotStarted", false)[0].Controls.Add(taskBox);
                taskBox.BackColor = System.Drawing.Color.LightGray;
            }
            else if(Type == TaskType.IN_PROGRESS)
            {
                Program.MainForm.Controls.Find(StoryBoxName + "_InProgress", false)[0].Controls.Add(taskBox);
                taskBox.BackColor = System.Drawing.Color.Yellow;
            }
            else if (Type == TaskType.DONE)
            {
                Program.MainForm.Controls.Find(StoryBoxName + "_Done", false)[0].Controls.Add(taskBox);
                taskBox.BackColor = System.Drawing.Color.LimeGreen;
            }
        }
    }

    public enum TaskType
    {
        NOT_STARTED,
        IN_PROGRESS,
        DONE
    }
}
