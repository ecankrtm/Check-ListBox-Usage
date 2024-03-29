using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Country
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add("Item1");
            checkedListBox1.Items.Add("Item2");
            checkedListBox1.Items.Add("Item3");
            checkedListBox1.Items.Add("Item4");
            checkedListBox1.Items.Add("Item5");
            checkedListBox1.Items.Add("Item6");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedItems = "Selected Items:\n";
            foreach (var item in checkedListBox1.CheckedItems)
            {
                selectedItems += item.ToString() + "\n";
            }

            MessageBox.Show(selectedItems, "Selected Items", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
