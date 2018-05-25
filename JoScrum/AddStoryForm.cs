using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;

namespace JoScrum
{
    public partial class AddStoryForm : MaterialForm
    {
        public AddStoryForm()
        {
            InitializeComponent();
        }

        private void AddStoryForm_Load(object sender, EventArgs e)
        {
            materialLabel1.ForeColor = Color.White;
        }

        private void btnAddStory_Click(object sender, EventArgs e)
        {
            JoScrum.AddStory(txtStory.Text);
            this.Hide();
        }
    }
}
