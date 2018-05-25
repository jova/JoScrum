using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace JoScrum
{
    public static class JoScrum
    {
        public static string DB_PATH = AppDomain.CurrentDomain.BaseDirectory + "JoScrum.db";

        public static List<Story> Stories = new List<Story>();

        public static void AddStory(string text)
        {
            Story story = new Story(text, string.Empty);

            using (LiteDatabase db = new LiteDatabase(DB_PATH))
            {
                var stories = db.GetCollection<Story>("Story");

                stories.Insert(story);
            }

            Stories.Add(story);
        }

        public static void RemoveStory(string storyName)
        {
            using (LiteDatabase db = new LiteDatabase(DB_PATH))
            {
                var stories = db.GetCollection<Story>("Story");

                stories.Delete(Query.EQ("StoryBoxName", storyName));

                var tasks = db.GetCollection<StoryTask>("StoryTask");

                tasks.Delete(Query.EQ("StoryBoxName", storyName));
            }

            Stories.Remove(Stories.Find(x => x.StoryBoxName == storyName));

            Program.MainForm.Controls.Remove(Program.MainForm.Controls.Find(storyName, false)[0]);
            Program.MainForm.Controls.Remove(Program.MainForm.Controls.Find(storyName + "_NotStarted", false)[0]);
            Program.MainForm.Controls.Remove(Program.MainForm.Controls.Find(storyName + "_InProgress", true)[0]);
            Program.MainForm.Controls.Remove(Program.MainForm.Controls.Find(storyName + "_Done", true)[0]);
        }

        public static void RemoveTask(string panelName, string taskName)
        {
            string storyName = panelName.Split('_')[0];
            StoryTask task = Stories.Find(x => x.StoryBoxName == storyName).Tasks.Find(x => x.Name == taskName);

            using (LiteDatabase db = new LiteDatabase(DB_PATH))
            {
                var tasks = db.GetCollection<StoryTask>("StoryTask");

                tasks.Delete(Query.EQ("Name", taskName));
            }

            Stories.Find(x => x.StoryBoxName == storyName).Tasks.Remove(task);

            Program.MainForm.Controls.Find(panelName, false)[0].Controls.Remove(Program.MainForm.Controls.Find(panelName, false)[0].Controls.Find(taskName, false)[0]);
        }

        public static void MoveToTask(string panelName, string taskName, TaskType taskType)
        {
            string storyName = panelName.Split('_')[0];
            string newPanelName = string.Empty;

            if (taskType == TaskType.NOT_STARTED)
            {
                newPanelName = storyName + "_NotStarted";
            }
            else if (taskType == TaskType.IN_PROGRESS)
            {
                newPanelName = storyName + "_InProgress";
            }
            else if (taskType == TaskType.DONE)
            {
                newPanelName = storyName + "_Done";
            }

            if (panelName == newPanelName)
            {
                return;
            }

            StoryTask task = Stories.Find(x => x.StoryBoxName == storyName).Tasks.Find(x => x.Name == taskName);
            task.Type = taskType;

            using (LiteDatabase db = new LiteDatabase(DB_PATH))
            {
                var tasks = db.GetCollection<StoryTask>("StoryTask");

                tasks.Update(task);
            }

            Program.MainForm.Controls.Find(newPanelName, false)[0].Controls.Add(Program.MainForm.Controls.Find(panelName, false)[0].Controls.Find(taskName, false)[0]);
        }

        public static StoryTask GetTask(string panelName, string taskName)
        {
            string storyName = panelName.Split('_')[0];

            StoryTask task = Stories.Find(x => x.StoryBoxName == storyName).Tasks.Find(x => x.Name == taskName);

            return task;
        }

        public static void UpdateDatabase()
        {
            List<Story> tempStories = new List<Story>();
            using (LiteDatabase db = new LiteDatabase(DB_PATH))
            {
                var stories = db.GetCollection<Story>("Story");

                tempStories = stories.FindAll().ToList();
            }

            foreach (Story story in tempStories)
            {
                Story newStory = new Story(story.Text, story.StoryBoxName);
                Stories.Add(newStory);
            }
        }
    }
}
