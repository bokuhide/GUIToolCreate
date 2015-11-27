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
        public MapForm()
        {
            InitializeComponent();
        }

        private void instanceEdit_Click(object sender, EventArgs e)
        {
            editor = new EditorForm();
            editor.Show();
        }
    }
}
