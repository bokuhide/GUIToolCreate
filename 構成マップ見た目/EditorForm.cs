using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 構成マップ見た目
{
    public partial class EditorForm : Form
    {

        int index_iamge = 0;
        int index_flavor = 0;
        int index_net = 0;

        
        public static List<string> edit_data1 = new List<string> { };

        public EditorForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EditorForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            index_iamge = comboBox2.SelectedIndex;
            edit_data1.Add(comboBox2.Items[index_iamge].ToString());

            index_flavor = comboBox4.SelectedIndex;
            edit_data1.Add(comboBox4.Items[index_flavor].ToString());

            index_net = comboBox3.SelectedIndex;
            edit_data1.Add(comboBox3.Items[index_net].ToString());

           


            string instance_name = textBox1.Text;
            MessageBox.Show(edit_data1[0]);

        }
    }
}
