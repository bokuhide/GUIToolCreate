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
    public partial class MapForm : Form
    {
        Form editor;
        //public List<string> edit_data = new List<string> { };

        public MapForm()
        {
            InitializeComponent();
        }

        private void instanceEdit_Click(object sender, EventArgs e)
        {
            
            editor = new EditorForm();
            editor.Owner = this;
            editor.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            //edit_data[0] = EditorForm.edit_data1[0];
            MessageBox.Show(EditorForm.edit_data1[0]);
        }
    }
}
