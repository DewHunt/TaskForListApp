using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskForListApp
{
    public partial class ListNameUI : Form
    {
        public ListNameUI()
        {
            InitializeComponent();
        }
         
        List<string> nameList = new List<string>();

        private void saveButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;

            nameList.Add(name);

            nameListBox.Items.Add(name);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchName = searchNameTextBox.Text;

            if (nameList.Contains(searchName))
            {
                searchNameListBox.Items.Add(searchName);
            }
            else
            {
                NotFoundNameListBox.Items.Add(searchName + " is Not Found");
            }
        }
    }
}
