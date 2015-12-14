using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//２つ目のinstance編集画面
namespace 構成マップ見た目
{
    public partial class EditorForm1 : Form
    {

        int index_iamge = 0;
        int index_flavor = 0;
        int index_net = 0;
        //Form map;

        public static List<string> edit_data1 = new List<string> { };

        public EditorForm1()
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
            //index_iamge = imageComboBox.SelectedIndex;
            //edit_data1.Add(imageComboBox.Items[index_iamge].ToString());

            //index_flavor = flavorComboBox.SelectedIndex;
            //edit_data1.Add(flavorComboBox.Items[index_flavor].ToString());

           // index_net = networkComboBox.SelectedIndex;
            //edit_data1.Add(networkComboBox.Items[index_net].ToString());




           // string instance_name = textBox1.Text;
            // MessageBox.Show(edit_data1[0]);

            //this.Close();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            index_iamge = comboBox2.SelectedIndex;
            edit_data1.Add(comboBox2.Items[index_iamge].ToString());

            index_flavor = comboBox4.SelectedIndex;
            edit_data1.Add(comboBox4.Items[index_flavor].ToString());

            index_net = comboBox3.SelectedIndex;
            edit_data1.Add(comboBox3.Items[index_net].ToString());




            string instance_name = textBox1.Text;

            edit_data1.Add(instance_name);
            // MessageBox.Show(edit_data1[0]);

            this.Close();
        }
    }
}
