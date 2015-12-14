using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 構成マップ見た目
{
    public class InstanceConfig
    {
        public String instanceName;
        public int imageNum;
        public int flavorNum;
        public int networkNum;
        public string imageName;
        public string flavorName;
        public string networkName;

        public InstanceConfig()
        {
            this.instanceName = "";
            this.imageNum = 0;
            this.flavorNum = 0;
            this.networkNum = 0;
            this.imageName = "";
            this.flavorName = "";
            this.networkName = "";

        }
    }
}
