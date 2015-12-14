using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//ひとつ目のinstance編集画面
namespace 構成マップ見た目
{
    public partial class EditorForm : Form
    {
        InstanceConfig instanceConfig;
        
        public EditorForm(InstanceConfig ic)
        {
            InitializeComponent();

            this.instanceConfig = ic;

            textBox1.Text = ic.instanceName;
            imageComboBox.SelectedIndex = ic.imageNum;
            networkComboBox.SelectedIndex = ic.networkNum;
            flavorComboBox.SelectedIndex = ic.flavorNum;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EditorForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.instanceConfig.imageNum = imageComboBox.SelectedIndex;
            this.instanceConfig.imageName = imageComboBox.SelectedItem.ToString();
            this.instanceConfig.flavorNum = flavorComboBox.SelectedIndex;
            this.instanceConfig.flavorName = flavorComboBox.SelectedItem.ToString();
            this.instanceConfig.networkNum = networkComboBox.SelectedIndex;
            this.instanceConfig.networkName = networkComboBox.SelectedItem.ToString();

            this.instanceConfig.instanceName = textBox1.Text;
            // MessageBox.Show(edit_data1[0]);
            


            this.Close();

        }
    }
}
