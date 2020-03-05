using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TODOLIST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddToDo_Click(object sender, EventArgs e)
        {
            string newItem = txtNewToDo.Text.Trim();

            if (!String.IsNullOrWhiteSpace(newItem))
            {

                if (clsToDo.Items.Contains(newItem))
                {
                    MessageBox.Show("You alreday added that item", "Error");
                }
            
            else
            {
                DateTime todoCreated = DateTime.Now;
                bool urgent = chkUrgent.Checked;


                string todoText = $" {newItem} - Created at {todoCreated:f}";
                if (urgent)
                {
                    todoText += "URGENT!";
                }
                  //add to the Listbox items
                    clsToDo.Items.Add(todoText);


                    //clearing inputs
                    txtNewToDo.Text = "";
                    chkUrgent.Checked = false;


            }
                
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<string> doneItems = new List<string>();

            foreach ( string item in clsToDo.CheckedItems)
            {
                doneItems.Add(item);
            }

            foreach (string item in doneItems)
            {
                clsToDo.Items.Remove(item);
                lstDone.Items.Add(item);
            }
        }
    }
}
