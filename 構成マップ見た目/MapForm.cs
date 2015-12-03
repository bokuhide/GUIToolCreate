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
            MessageBox.Show("Hello!!");
            Console.WriteLine("Button1がクリックされました");
        }

        //テンプレートファイル出力部分
        private void fileExport()
        {
            Encoding sjisEnc = Encoding.GetEncoding("Shift_JIS");
            StreamWriter writer = new StreamWriter(@"C:\testFile\text.txt", false, sjisEnc);

            string head = "heat_template_version: 2013-05-23\r\n";
            string parameters = "parameters:\r\n  ext-net:\r\n   type: string\r\n   description: ext-netID\r\n   default: ext-net\r\n";
            string resources = "resources:";
            string resourcesPrivatenet = " private1:\r\n   type: OS::Neutron::Net\r\n   properties:\r\n    name: ";

            //ここに入力された内部ネットワークの名前を挿入
            string net_name = " ";

           
            string resourcesSubnet = " \r\n private1-sub:\r\n   type: OS::Neutron::Subnet\r\n   depends_on: private1\r\n   properties:\r\n    network_id: {get_resource: private1}\r\n    cidr: 192.168.2.0/24\r\n";
            string resourcesRouter = " ext-router:\r\n   type: OS::Neutron::Router\r\n   properties:\r\n    external_gateway_info:\r\n     network: {get_param: ext-net}\r\n";
            string resourcesRouterInterface = " ext-router-interface:\r\n   type: OS::Neutron::RouterInterface\r\n   depends_on: [ext-router, private1-sub]\r\n   properties:\r\n    router_id: {get_resource: ext-router}\r\n    subnet_id: {get_resource: private1-sub}\r\n";
            string instance1Firsthalf = " instance1:\r\n   type: OS::Nova::Server\r\n   depends_on: private1-sub\r\n   properties:\r\n    image: ";

            //ここに入力されたimage名を入力
            string instance1image = " ";
            string instance1Secondhalf = "    flavor: ";

            //ここに入力されたflavorを入力
            string instance1flavor = "";
            string instance1Threadhalf = "    networks:\r\n     - network: {get_resource: private1}\r\n";

            //入力された値を格納
            net_name = EditorForm.edit_data1[2];
            instance1image = EditorForm.edit_data1[0];
            instance1flavor = EditorForm.edit_data1[1];

            //出力
            writer.WriteLine("{0}", head);
            writer.WriteLine("{0}", parameters);
            writer.WriteLine("{0}", resources);
            writer.Write("{0}", resourcesPrivatenet);
            writer.WriteLine("{0}", net_name);
            writer.WriteLine("{0}", resourcesSubnet);
            writer.WriteLine("{0}", resourcesRouter);
            writer.WriteLine("{0}", resourcesRouterInterface);
            writer.Write("{0}", instance1Firsthalf);
            writer.WriteLine("{0}", instance1image);
            writer.Write("{0}", instance1Secondhalf);
            writer.WriteLine("{0}", instance1flavor);
            writer.WriteLine("{0}", instance1Threadhalf);
            writer.Close();

            return;


        }

        
    }
}
