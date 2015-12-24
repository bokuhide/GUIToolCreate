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
        static public int count = 0;
        static public int count2 = 0;
        Form editor;
        //Form editor1;
        //public List<string> edit_data = new List<string> { };

        List<InstanceConfig> instanceConfigList;
        public MapForm()
        {
            InitializeComponent();

            this.instanceConfigList = new List<InstanceConfig>();
            this.instanceConfigList.Add(new InstanceConfig());//1つ目のインスタンス詳細入力画面用の
            this.instanceConfigList.Add(new InstanceConfig());
            this.instanceConfigList.Add(new InstanceConfig());
            this.instanceConfigList.Add(new InstanceConfig());
            this.instanceConfigList.Add(new InstanceConfig());
        }

        //初期配置、最初のinstance編集ボタンイベント
        private void instanceEdit_Click(object sender, EventArgs e)
        {
            
            editor = new EditorForm(this.instanceConfigList[0]);
            editor.Owner = this;
            editor.Show();
 
        }

        //次の配置、２つ目のinstance編集ボタンイベント
        private void instanceEdit1_Click(object sender, EventArgs e)
        {
            editor = new EditorForm(this.instanceConfigList[1]);
            editor.Owner = this;
            editor.Show();
        }

        //３つ目のinstance編集ボタンイベント
        private void button2_Click(object sender, EventArgs e)
        {
            editor = new EditorForm(this.instanceConfigList[2]);
            editor.Owner = this;
            editor.Show();
        }
        //4つ目のinstance編集ボタンイベント
        private void instanceEdit3_Click(object sender, EventArgs e)
        {
            editor = new EditorForm(this.instanceConfigList[3]);
            editor.Owner = this;
            editor.Show();
        }

        //5つ目のinstance編集ボタンイベント
        private void instanceEdit4_Click(object sender, EventArgs e)
        {
            editor = new EditorForm(this.instanceConfigList[4]);
            editor.Owner = this;
            editor.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            fileExport();
            MessageBox.Show("テンプレートファイルへの出力が完了しました。");

        }

        private void routerCopy_Click(object sender, EventArgs e)
        {
            count++;
            if (count == 1)
            {
                this.BlindB.Location = new System.Drawing.Point(210, 1000);
            }
            else if (count == 2)
            {
                this.BlindD.Location = new System.Drawing.Point(210, 1000);
                this.routerCopy.Location = new System.Drawing.Point(900, 100);
            }
        }
        private void Networkconnect()
        {
            this.demo1A1a.Location = new System.Drawing.Point(900, 100);
            this.demo1A1b.Location = new System.Drawing.Point(900, 100);
            this.demo1A1c.Location = new System.Drawing.Point(900, 100);
            this.demo1A2a.Location = new System.Drawing.Point(900, 100);
            this.demo1A2b.Location = new System.Drawing.Point(900, 100);
            this.demo1A3a.Location = new System.Drawing.Point(900, 100);
            this.demo1A3b.Location = new System.Drawing.Point(900, 100);
            this.demo1A4a.Location = new System.Drawing.Point(900, 100);
            this.demo1A4b.Location = new System.Drawing.Point(900, 100);
            this.demo1A5a.Location = new System.Drawing.Point(900, 100);
            this.demo1A5b.Location = new System.Drawing.Point(900, 100);


            this.demo2A1a.Location = new System.Drawing.Point(900, 100);
            this.demo2A1b.Location = new System.Drawing.Point(900, 100);
            this.demo2A1c.Location = new System.Drawing.Point(900, 100);
            this.demo2A2a.Location = new System.Drawing.Point(900, 100);
            this.demo2A2b.Location = new System.Drawing.Point(900, 100);
            this.demo2A3a.Location = new System.Drawing.Point(900, 100);
            this.demo2A3b.Location = new System.Drawing.Point(900, 100);
            this.demo2A4a.Location = new System.Drawing.Point(900, 100);
            this.demo2A4b.Location = new System.Drawing.Point(900, 100);
            this.demo2A5a.Location = new System.Drawing.Point(900, 100);
            this.demo2A5b.Location = new System.Drawing.Point(900, 100);

            this.demo3A1a.Location = new System.Drawing.Point(900, 100);
            this.demo3A1b.Location = new System.Drawing.Point(900, 100);
            this.demo3A1c.Location = new System.Drawing.Point(900, 100);
            this.demo3A2a.Location = new System.Drawing.Point(900, 100);
            this.demo3A2b.Location = new System.Drawing.Point(900, 100);
            this.demo3A3a.Location = new System.Drawing.Point(900, 100);
            this.demo3A3b.Location = new System.Drawing.Point(900, 100);
            this.demo3A4a.Location = new System.Drawing.Point(900, 100);
            this.demo3A4b.Location = new System.Drawing.Point(900, 100);
            this.demo3A5a.Location = new System.Drawing.Point(900, 100);
            this.demo3A5b.Location = new System.Drawing.Point(900, 100);
            if (count2 >= 1)
            {
                if (this.instanceConfigList[0].networkName == "demo-net1")
                {
                    this.demo1A1a.Location = new System.Drawing.Point(210, 70);
                    this.demo1A1b.Location = new System.Drawing.Point(210, 70);
                    this.demo1A1c.Location = new System.Drawing.Point(160, 220);
                }
                else if (this.instanceConfigList[0].networkName == "demo-net2")
                {
                    this.demo2A1a.Location = new System.Drawing.Point(240, 70);
                    this.demo2A1b.Location = new System.Drawing.Point(240, 70);
                    this.demo2A1c.Location = new System.Drawing.Point(160, 440);
                }
                else if (this.instanceConfigList[0].networkName == "demo-net3")
                {
                    this.demo3A1a.Location = new System.Drawing.Point(270, 70);
                    this.demo3A1b.Location = new System.Drawing.Point(270, 70);
                    this.demo3A1c.Location = new System.Drawing.Point(160, 665);
                }
            }
            if (count2 >= 2)
            {
                if (this.instanceConfigList[1].networkName == "demo-net1")
                {
                    this.demo1A2a.Location = new System.Drawing.Point(210, 160);
                    this.demo1A2b.Location = new System.Drawing.Point(210, 160);
                    this.demo1A1c.Location = new System.Drawing.Point(160, 220);
                }
                else if (this.instanceConfigList[1].networkName == "demo-net2")
                {
                    this.demo2A2a.Location = new System.Drawing.Point(240, 160);
                    this.demo2A2b.Location = new System.Drawing.Point(240, 160);
                    this.demo2A1c.Location = new System.Drawing.Point(160, 440);
                }
                else if (this.instanceConfigList[1].networkName == "demo-net3")
                {
                    this.demo3A2a.Location = new System.Drawing.Point(270, 160);
                    this.demo3A2b.Location = new System.Drawing.Point(270, 160);
                    this.demo3A1c.Location = new System.Drawing.Point(160, 665);
                }
            }
            if (count2 >= 3)
            {
                if (this.instanceConfigList[2].networkName == "demo-net1")
                {
                    this.demo1A3a.Location = new System.Drawing.Point(210, 270);
                    this.demo1A3b.Location = new System.Drawing.Point(210, 220);
                    this.demo1A1c.Location = new System.Drawing.Point(160, 220);
                }
                else if (this.instanceConfigList[2].networkName == "demo-net2")
                {
                    this.demo2A3a.Location = new System.Drawing.Point(240, 270);
                    this.demo2A3b.Location = new System.Drawing.Point(240, 270);
                    this.demo2A1c.Location= new System.Drawing.Point(160, 440);
                }
                else if (this.instanceConfigList[2].networkName == "demo-net3")
                {
                    this.demo3A3a.Location = new System.Drawing.Point(270, 270);
                    this.demo3A3b.Location = new System.Drawing.Point(270, 270);
                    this.demo3A1c.Location = new System.Drawing.Point(160, 665);
                }
            }
            if (count2 >= 4)
            {
                if (this.instanceConfigList[3].networkName == "demo-net1")
                {
                    this.demo1A4a.Location = new System.Drawing.Point(210, 360);
                    this.demo1A4b.Location = new System.Drawing.Point(210, 220);
                    this.demo1A1c.Location = new System.Drawing.Point(160, 220);
                }
                else if (this.instanceConfigList[3].networkName == "demo-net2")
                {
                    this.demo2A4a.Location = new System.Drawing.Point(240, 360);
                    this.demo2A4b.Location = new System.Drawing.Point(240, 360);
                    this.demo2A1c.Location = new System.Drawing.Point(160, 440);
                }
                else if (this.instanceConfigList[3].networkName == "demo-net3")
                {
                    this.demo3A4a.Location = new System.Drawing.Point(270, 360);
                    this.demo3A4b.Location = new System.Drawing.Point(270, 360);
                    this.demo3A1c.Location = new System.Drawing.Point(160, 665);
                }
            }
            if (count2 >= 5)
            {
                if (this.instanceConfigList[4].networkName == "demo-net1")
                {
                    this.demo1A5a.Location = new System.Drawing.Point(210, 455);
                    this.demo1A5b.Location = new System.Drawing.Point(210, 220);
                    this.demo1A1c.Location = new System.Drawing.Point(160, 220);
                }
                else if (this.instanceConfigList[4].networkName == "demo-net2")
                {
                    this.demo2A5a.Location = new System.Drawing.Point(240, 440);
                    this.demo2A1c.Location = new System.Drawing.Point(160, 440);
                }
                else if (this.instanceConfigList[4].networkName == "demo-net3")
                {
                    this.demo3A5a.Location = new System.Drawing.Point(270, 455);
                    this.demo3A5b.Location = new System.Drawing.Point(270, 455);
                    this.demo3A1c.Location = new System.Drawing.Point(160, 665);
                }
            }
        }
        //テンプレートファイル出力部分
        private void fileExport()
        {
            Encoding sjisEnc = Encoding.GetEncoding("Shift_JIS");
            StreamWriter writer = new StreamWriter(@"..\..\..\text.txt", false, sjisEnc);

            string head = "heat_template_version: 2013-05-23\r\n";
            string parameters = "parameters:\r\n  ext-net:\r\n   type: string\r\n   description: ext-netID\r\n   default: ext-net\r\n";
            string resources = "resources:";

            string resourcesPrivatenet1 = " private1:\r\n   type: OS::Neutron::Net\r\n   properties:\r\n    name: ";
            string resourcesPrivatenet2 = " private2:\r\n   type: OS::Neutron::Net\r\n   properties:\r\n    name: ";
            string resourcesPrivatenet3 = " private3:\r\n   type: OS::Neutron::Net\r\n   properties:\r\n    name: ";

            //ここに入力された内部ネットワークの名前を挿入
            //string instance1_net = "";
            //string instance2_net = "";

            string net_name1 = "demo-net1";
            string net_name2 = "demo-net2";
            string net_name3 = "demo-net3";

            string resourcesSubnet1 = " \r\n private1-sub:\r\n   type: OS::Neutron::Subnet\r\n   depends_on: private1\r\n   properties:\r\n    network_id: {get_resource: private1}\r\n    cidr: 192.168.2.0/24\r\n";
            string resourcesSubnet2 = " \r\n private2-sub:\r\n   type: OS::Neutron::Subnet\r\n   depends_on: private2\r\n   properties:\r\n    network_id: {get_resource: private2}\r\n    cidr: 192.168.3.0/24\r\n";
            string resourcesSubnet3 = " \r\n private3-sub:\r\n   type: OS::Neutron::Subnet\r\n   depends_on: private3\r\n   properties:\r\n    network_id: {get_resource: private3}\r\n    cidr: 192.168.4.0/24\r\n";

            string resourcesRouter1 = " ext-router1:\r\n   type: OS::Neutron::Router\r\n   properties:\r\n    external_gateway_info:\r\n     network: {get_param: ext-net}\r\n";
            string resourcesRouter2 = " ext-router2:\r\n   type: OS::Neutron::Router\r\n   properties:\r\n    external_gateway_info:\r\n     network: {get_param: ext-net}\r\n";
            string resourcesRouter3 = " ext-router3:\r\n   type: OS::Neutron::Router\r\n   properties:\r\n    external_gateway_info:\r\n     network: {get_param: ext-net}\r\n";

            string resourcesRouterInterface1 = " ext-router1-interface:\r\n   type: OS::Neutron::RouterInterface\r\n   depends_on: [ext-router1, private1-sub]\r\n   properties:\r\n    router_id: {get_resource: ext-router1}\r\n    subnet_id: {get_resource: private1-sub}\r\n";
            string resourcesRouterInterface2 = " ext-router2-interface:\r\n   type: OS::Neutron::RouterInterface\r\n   depends_on: [ext-router2, private2-sub]\r\n   properties:\r\n    router_id: {get_resource: ext-router2}\r\n    subnet_id: {get_resource: private2-sub}\r\n";
            string resourcesRouterInterface3 = " ext-router3-interface:\r\n   type: OS::Neutron::RouterInterface\r\n   depends_on: [ext-router3, private3-sub]\r\n   properties:\r\n    router_id: {get_resource: ext-router3}\r\n    subnet_id: {get_resource: private3-sub}\r\n";

            string instance1Firsthalf = " instance1:\r\n   type: OS::Nova::Server\r\n   depends_on: ";
            string instance1depend_subnet = "";
            string instance1Firsthalf2 = "\r\n   properties:\r\n    name: \"";
            string instance1_name = "";
            string exportparts = "\"";
            string instance1_image_properties = "    image: ";
            string instance1_image = " ";
            string instance1Secondhalf = "    flavor: ";
            string instance1flavor = "";
            string instance1Threadhalf = "    networks:\r\n     - network: {get_resource: ";
            string instance1connect_net = "";
            string instance1Forthhalf = "}\r\n";


            string instance2Firsthalf = " instance2:\r\n   type: OS::Nova::Server\r\n   depends_on: ";
            string instance2depend_subnet = "";
            string instance2Firsthalf2 = "\r\n   properties:\r\n    name: \""; 
            string instance2_name = "";
            string instance2_image_properties = "    image: ";
            string instance2_image = "";
            string instance2Secondhalf = "    flavor: ";
            string instance2flavor = "";
            string instance2Threadhalf = "    networks:\r\n     - network: {get_resource: ";
            string instance2connect_net = "";
            string instance2Forthhalf = "}\r\n";

            string instance3Firsthalf = " instance3:\r\n   type: OS::Nova::Server\r\n   depends_on: ";
            string instance3depend_subnet = "";
            string instance3Firsthalf2 = "\r\n   properties:\r\n    name: \"";
            string instance3_name = "";
            string instance3_image_properties = "    image: ";
            string instance3_image = "";
            string instance3Secondhalf = "    flavor: ";
            string instance3flavor = "";
            string instance3Threadhalf = "    networks:\r\n     - network: {get_resource: ";
            string instance3connect_net = "";
            string instance3Forthhalf = "}\r\n";

            string instance4Firsthalf = " instance4:\r\n   type: OS::Nova::Server\r\n   depends_on: ";
            string instance4depend_subnet = "";
            string instance4Firsthalf2 = "\r\n   properties:\r\n    name: \"";
            string instance4_name = "";
            string instance4_image_properties = "    image: ";
            string instance4_image = "";
            string instance4Secondhalf = "    flavor: ";
            string instance4flavor = "";
            string instance4Threadhalf = "    networks:\r\n     - network: {get_resource: ";
            string instance4connect_net = "";
            string instance4Forthhalf = "}\r\n";

            string instance5Firsthalf = " instance5:\r\n   type: OS::Nova::Server\r\n   depends_on: ";
            string instance5depend_subnet = "";
            string instance5Firsthalf2 = "\r\n   properties:\r\n    name: \"";
            string instance5_name = "";
            string instance5_image_properties = "    image: ";
            string instance5_image = "";
            string instance5Secondhalf = "    flavor: ";
            string instance5flavor = "";
            string instance5Threadhalf = "    networks:\r\n     - network: {get_resource: ";
            string instance5connect_net = "";
            string instance5Forthhalf = "}\r\n";

            //入力された値を格納
            if (this.instanceConfigList[0].networkName == "demo-net1")
            {
                instance1depend_subnet = "private1-sub";
                instance1connect_net = "private1";
            }
            else if (this.instanceConfigList[0].networkName == "demo-net2")
            {
                instance1depend_subnet = "private2-sub";
                instance1connect_net = "private2";
            }
            else if (this.instanceConfigList[0].networkName == "demo-net3")
            {
                instance1depend_subnet = "private3-sub";
                instance1connect_net = "private3";
            }

            instance1_name = this.instanceConfigList[0].instanceName;
            instance1_image = this.instanceConfigList[0].imageName;
            instance1flavor = this.instanceConfigList[0].flavorName;

            //以下出力
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
            writer.Write("{0}", instance1depend_subnet);
            writer.Write("{0}", instance1Firsthalf2);
            writer.Write("{0}", instance1_name);
            writer.WriteLine("{0}", exportparts);
            writer.Write("{0}", instance1_image_properties);
            writer.WriteLine("{0}", instance1_image);
            writer.Write("{0}", instance1Secondhalf);
            writer.WriteLine("{0}", instance1flavor);
            writer.Write("{0}", instance1Threadhalf);
            writer.Write("{0}", instance1connect_net);
            writer.WriteLine("{0}", instance1Forthhalf);
            if (count2>=2)
            {
                if (this.instanceConfigList[1].networkName == "demo-net1")
                {
                    instance2depend_subnet = "private1-sub";
                    instance2connect_net = "private1";
                }
                else if (this.instanceConfigList[1].networkName == "demo-net2")
                {
                    instance2depend_subnet = "private2-sub";
                    instance2connect_net = "private2";
                }
                else if (this.instanceConfigList[1].networkName == "demo-net3")
                {
                    instance2depend_subnet = "private3-sub";
                    instance2connect_net = "private3";
                }

                instance2_name = this.instanceConfigList[1].instanceName;
                instance2_image = this.instanceConfigList[1].imageName;
                instance2flavor = this.instanceConfigList[1].flavorName;
 
                writer.Write("{0}", instance2Firsthalf);
                writer.Write("{0}", instance2depend_subnet);
                writer.Write("{0}", instance2Firsthalf2);
                writer.Write("{0}", instance2_name);
                writer.WriteLine("{0}", exportparts);
                writer.Write("{0}", instance2_image_properties);
                writer.WriteLine("{0}", instance2_image);
                writer.Write("{0}", instance2Secondhalf);
                writer.WriteLine("{0}", instance2flavor);
                writer.Write("{0}", instance2Threadhalf);
                writer.Write("{0}", instance2connect_net);
                writer.WriteLine("{0}", instance2Forthhalf);

            }

            if (count2 >= 3)
            {
                if (this.instanceConfigList[2].networkName == "demo-net1")
                {
                    instance3depend_subnet = "private1-sub";
                    instance3connect_net = "private1";
                }
                else if (this.instanceConfigList[2].networkName == "demo-net2")
                {
                    instance3depend_subnet = "private2-sub";
                    instance3connect_net = "private2";
                }
                else if (this.instanceConfigList[2].networkName == "demo-net3")
                {
                    instance3depend_subnet = "private3-sub";
                    instance3connect_net = "private3";
                }
                instance3_name = this.instanceConfigList[2].instanceName;
                instance3_image = this.instanceConfigList[2].imageName;
                instance3flavor = this.instanceConfigList[2].flavorName;

                writer.Write("{0}", instance3Firsthalf);
                writer.Write("{0}", instance3depend_subnet);
                writer.Write("{0}", instance3Firsthalf2);
                writer.Write("{0}", instance3_name);
                writer.WriteLine("{0}", exportparts);
                writer.Write("{0}", instance3_image_properties);
                writer.WriteLine("{0}", instance3_image);
                writer.Write("{0}", instance3Secondhalf);
                writer.WriteLine("{0}", instance3flavor);
                writer.Write("{0}", instance3Threadhalf);
                writer.Write("{0}", instance3connect_net);
                writer.WriteLine("{0}", instance3Forthhalf);

            }

            if (count2 >= 4)
            {
                if (this.instanceConfigList[3].networkName == "demo-net1")
                {
                    instance4depend_subnet = "private1-sub";
                    instance4connect_net = "private1";
                }
                else if (this.instanceConfigList[3].networkName == "demo-net2")
                {
                    instance4depend_subnet = "private2-sub";
                    instance4connect_net = "private2";
                }
                else if (this.instanceConfigList[3].networkName == "demo-net3")
                {
                    instance4depend_subnet = "private3-sub";
                    instance4connect_net = "private3";
                }
                instance4_name = this.instanceConfigList[3].instanceName;
                instance4_image = this.instanceConfigList[3].imageName;
                instance4flavor = this.instanceConfigList[3].flavorName;

                writer.Write("{0}", instance4Firsthalf);
                writer.Write("{0}", instance4depend_subnet);
                writer.Write("{0}", instance4Firsthalf2);
                writer.Write("{0}", instance4_name);
                writer.WriteLine("{0}", exportparts);
                writer.Write("{0}", instance4_image_properties);
                writer.WriteLine("{0}", instance4_image);
                writer.Write("{0}", instance4Secondhalf);
                writer.WriteLine("{0}", instance4flavor);
                writer.Write("{0}", instance4Threadhalf);
                writer.Write("{0}", instance4connect_net);
                writer.WriteLine("{0}", instance4Forthhalf);

            }

            if (count2 >= 5)
            {
                if (this.instanceConfigList[4].networkName == "demo-net1")
                {
                    instance5depend_subnet = "private1-sub";
                    instance5connect_net = "private1";
                }
                else if (this.instanceConfigList[4].networkName == "demo-net2")
                {
                    instance5depend_subnet = "private2-sub";
                    instance5connect_net = "private2";
                }
                else if (this.instanceConfigList[4].networkName == "demo-net3")
                {
                    instance5depend_subnet = "private3-sub";
                    instance5connect_net = "private3";
                }
                instance5_name = this.instanceConfigList[4].instanceName;
                instance5_image = this.instanceConfigList[4].imageName;
                instance5flavor = this.instanceConfigList[4].flavorName;

                writer.Write("{0}", instance5Firsthalf);
                writer.Write("{0}", instance5depend_subnet);
                writer.Write("{0}", instance5Firsthalf2);
                writer.Write("{0}", instance5_name);
                writer.WriteLine("{0}", exportparts);
                writer.Write("{0}", instance5_image_properties);
                writer.WriteLine("{0}", instance5_image);
                writer.Write("{0}", instance5Secondhalf);
                writer.WriteLine("{0}", instance5flavor);
                writer.Write("{0}", instance5Threadhalf);
                writer.Write("{0}", instance5connect_net);
                writer.WriteLine("{0}", instance5Forthhalf);

            }
            writer.Close();

            return;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            count2++;
            if (count2 == 1)
            {
                this.BlindA1.Location = new System.Drawing.Point(210, 1000);

            }
            else if (count2 == 2)
            {
                this.BlindA2.Location = new System.Drawing.Point(210, 1000);
            }
            else if (count2 == 3)
            {
                this.BlindA3.Location = new System.Drawing.Point(210, 1000);
            }
            else if (count2 == 4)
            {
                this.BlindA4.Location = new System.Drawing.Point(210, 1000);
            }
            else if (count2 == 5)
            {
                this.BlindA5.Location = new System.Drawing.Point(210, 1000);
                this.instantiation.Location = new System.Drawing.Point(900, 1000);
            }

        }
    
        private void button4_Click(object sender, EventArgs e)
        {
            Networkconnect();

        }

        private void MapForm_Load(object sender, EventArgs e)
        {

        }

        private void demo3A2a_Click(object sender, EventArgs e)
        {

        }

        private void demo3A4b_Click(object sender, EventArgs e)
        {

        }
    }
}
