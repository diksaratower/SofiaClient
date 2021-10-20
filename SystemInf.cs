using System;
using System.Windows.Forms;
using System.Xml;

namespace BackdoorClient
{
    public partial class SystemInf : Form
    {
        public SystemInf()
        {
            InitializeComponent();
        }

        private void updateBut_Click(object sender, EventArgs e)
        {
           
        }

        private void GetUpdateParameters()
        {
            var docContent = "";
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(docContent);

            XmlNode root = doc.FirstChild;

            var textIP = "";
            var textTime = "";
            var textMname = "";
            var textUsName = "";
            var textBuildNum = "";
            var textSys = "";


            if (root.HasChildNodes)
            {
                for (int i = 0; i < root.ChildNodes.Count; i++)
                {
                    if (root.ChildNodes[i].Name == "ip")
                        textIP = root.ChildNodes[i].InnerText;
                    if (root.ChildNodes[i].Name == "time")
                        textTime = root.ChildNodes[i].InnerText;
                    if (root.ChildNodes[i].Name == "machineName")
                        textMname = root.ChildNodes[i].InnerText;
                    if (root.ChildNodes[i].Name == "usName")
                        textUsName = root.ChildNodes[i].InnerText;
                    if (root.ChildNodes[i].Name == "buildNum")
                        textBuildNum = root.ChildNodes[i].InnerText;
                    if (root.ChildNodes[i].Name == "sys")
                        textSys = root.ChildNodes[i].InnerText;
                }
            }
            ipAddrLabel.Text = textIP;
            SystemTimeLabel.Text = textTime;
            SysNameLabel.Text = "";
            usNameLabel.Text = textUsName;
            numBuildLabel.Text = textBuildNum;
            SysNameLabel.Text = textSys;
        }
    }
}
