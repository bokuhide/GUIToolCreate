using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 構成マップ見た目
{
    public partial class MapForm : Form
    {
        int count = 0;
        int count2 = 0;
        Form editor;
        Form editor1;
        //public List<string> edit_data = new List<string> { };

        public MapForm()
        {
            InitializeComponent();
        }

        //初期配置、最初のinstance編集ボタンイベント
        private void instanceEdit_Click(object sender, EventArgs e)
        {
            
            editor = new EditorForm();
            editor.Owner = this;
            editor.Show();
 
        }

        //次の配置、２つ目のinstance編集ボタンイベント
        private void instanceEdit1_Click(object sender, EventArgs e)
        {
            editor1 = new EditorForm1();
            editor1.Owner = this;
            editor1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //edit_data[0] = EditorForm.edit_data1[0];
            //MessageBox.Show(EditorForm.edit_data1[0]);
            fileExport();
            MessageBox.Show("テンプレートファイルへの出力が完了しました。");

        }

        private void routerCopy_Click(object sender, EventArgs e)
        {
            count++;
            if (count == 1)
            {
                this.pictureBox9.Location = new System.Drawing.Point(210, 1000);
            }
            else if (count == 2)
            {
                this.pictureBox15.Location = new System.Drawing.Point(210, 1000);
            }
        }

        //テンプレートファイル出力部分
        private void fileExport()
        {
            Encoding sjisEnc = Encoding.GetEncoding("Shift_JIS");
            StreamWriter writer = new StreamWriter(@"C:\testFile\text.txt", false, sjisEnc);

            string head = "heat_template_version: 2013-05-23\r\n";
            string parameters = "parameters:\r\n  ext-net:\r\n   type: string\r\n   description: ext-netID\r\n   default: ext-net\r\n";
            string resources = "resources:";

            string resourcesPrivatenet1 = " private1:\r\n   type: OS::Neutron::Net\r\n   properties:\r\n    name: ";            
            string resourcesPrivatenet2 = " private2:\r\n   type: OS::Neutron::Net\r\n   properties:\r\n    name: ";

            //ここに入力された内部ネットワークの名前を挿入
            string instance1_net = "";
            string instance2_net = "";

            string net_name1 = "demo-net";
            string net_name2 = "demo-net2";

            string resourcesSubnet1 = " \r\n private1-sub:\r\n   type: OS::Neutron::Subnet\r\n   depends_on: private1\r\n   properties:\r\n    network_id: {get_resource: private1}\r\n    cidr: 192.168.2.0/24\r\n";
            string resourcesSubnet2 = " \r\n private2-sub:\r\n   type: OS::Neutron::Subnet\r\n   depends_on: private2\r\n   properties:\r\n    network_id: {get_resource: private2}\r\n    cidr: 192.168.3.0/24\r\n";

            string resourcesRouter1 = " ext-router1:\r\n   type: OS::Neutron::Router\r\n   properties:\r\n    external_gateway_info:\r\n     network: {get_param: ext-net}\r\n";
            string resourcesRouter2 = " ext-router2:\r\n   type: OS::Neutron::Router\r\n   properties:\r\n    external_gateway_info:\r\n     network: {get_param: ext-net}\r\n";

            string resourcesRouterInterface1 = " ext-router1-interface:\r\n   type: OS::Neutron::RouterInterface\r\n   depends_on: [ext-router1, private1-sub]\r\n   properties:\r\n    router_id: {get_resource: ext-router1}\r\n    subnet_id: {get_resource: private1-sub}\r\n";
            string resourcesRouterInterface2 = " ext-router2-interface:\r\n   type: OS::Neutron::RouterInterface\r\n   depends_on: [ext-router2, private2-sub]\r\n   properties:\r\n    router_id: {get_resource: ext-router2}\r\n    subnet_id: {get_resource: private2-sub}\r\n";

            string instance1Firsthalf = " instance1:\r\n   type: OS::Nova::Server\r\n   depends_on: private1-sub\r\n   properties:\r\n    image: ";
            string instance2Firsthalf = " instance2:\r\n   type: OS::Nova::Server\r\n   depends_on: private1-sub\r\n   properties:\r\n    image: ";

            //ここに入力されたimage名を入力
            string instance1image = " ";
            string instance1Secondhalf = "    flavor: ";

            string instance2image = "";
            string instance2Secondhalf = "    flavor: ";

            //ここに入力されたflavorを入力
            string instance1flavor = "";
            string instance1Threadhalf = "    networks:\r\n     - network: {get_resource: private1}\r\n";

            string instance2flavor = "";
            string instance2Threadhalf = "    networks:\r\n     - network: {get_resource: private1}\r\n";

            //入力された値を格納
            instance1_net = EditorForm.edit_data1[2];
            instance1image = EditorForm.edit_data1[0];
            instance1flavor = EditorForm.edit_data1[1];

            //出力
            writer.WriteLine("{0}", head);
            writer.WriteLine("{0}", parameters);
            writer.WriteLine("{0}", resources);
            writer.Write("{0}", resourcesPrivatenet1);
            writer.WriteLine("{0}", net_name1);
            writer.WriteLine("{0}", resourcesSubnet1);
            writer.WriteLine("{0}", resourcesRouter1);
            writer.WriteLine("{0}", resourcesRouterInterface1);

            if (count >= 1)
            {
                
                writer.Write("{0}", resourcesPrivatenet2);
                writer.WriteLine("{0}", net_name2);
                writer.WriteLine("{0}", resourcesSubnet2);
                writer.WriteLine("{0}", resourcesRouter2);
                writer.WriteLine("{0}", resourcesRouterInterface2);
            }
            writer.Write("{0}", instance1Firsthalf);
            writer.WriteLine("{0}", instance1image);
            writer.Write("{0}", instance1Secondhalf);
            writer.WriteLine("{0}", instance1flavor);
            writer.WriteLine("{0}", instance1Threadhalf);
            if (count2>=2)
            {
                instance2_net = EditorForm1.edit_data1[2];
                instance2image = EditorForm1.edit_data1[0];
                instance2flavor = EditorForm1.edit_data1[1];
                //ここに２つ目のinstance編集内容を記述。おそらくフォーカス元のFormを変えるだけで基本操作は変わらない。
                writer.Write("{0}", instance2Firsthalf);
                writer.WriteLine("{0}", instance2image);
                writer.Write("{0}", instance2Secondhalf);
                writer.WriteLine("{0}", instance2flavor);
                writer.WriteLine("{0}", instance2Threadhalf);

            }
            writer.Close();

            return;


        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            count2++;
            if (count2 == 1)
            {
                this.pictureBox16.Location = new System.Drawing.Point(210, 1000);

            }
            else if (count2 == 2)
            {
                this.pictureBox17.Location = new System.Drawing.Point(210, 1000);
            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }
    }
}
