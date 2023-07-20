using RelationshipEF_LoadingDb_18._07_WF.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_First_Library_HW_WF
{
    public partial class Form_Search : Form
    {
        Dictionary<string, string> data;
        public Form_Search(Dictionary<string, string> data)
        {
            InitializeComponent();
            this.data = data;
            buttonSearch.Enabled = false;
        }

       

        private void radioButtonName_CheckedChanged(object sender, EventArgs e)
        {
            buttonSearch.Enabled = true;
        }

        private void radioButtonAuthor_CheckedChanged(object sender, EventArgs e)
        {
            buttonSearch.Enabled = true;
        }

        private void radioButtonCategory_CheckedChanged(object sender, EventArgs e)
        {
            buttonSearch.Enabled = true;
        }

        private void radioButtonPublishHouse_CheckedChanged(object sender, EventArgs e)
        {
            buttonSearch.Enabled = true;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string res = textBox1.Text;

            if (radioButtonName.Checked) { data.Add("Name", res); }
            else if (radioButtonAuthor.Checked) { data.Add("Author", res); }
            else if (radioButtonCategory.Checked) { data.Add("Category", res); }
            else if (radioButtonPublishHouse.Checked) { data.Add("PublishHouse", res); }
            this.Close();
        }
    }
}
