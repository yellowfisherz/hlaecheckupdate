using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace HLAEUpdateCheck
{
    public partial class MainWin : Form
    {
        public MainWin()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        private void Form_Shown(object sender, EventArgs e)
        {
            Thread Loadline = new Thread(Load2);
            Loadline.Start();
        }
        public void Load2()
        {
            string Getstr = "";
            string Getguid = "";
            try
            {
                StreamReader hlaeexe = new StreamReader("HLAE.exe");
                string Readhlae = hlaeexe.ReadToEnd();
                hlaeexe.Close();
                for (int i = 0; i < 500; i++)
                {
                    Getstr = Getstr + Readhlae[Readhlae.IndexOf("c\0u\0s\0t\0o\0m\0L\0a\0u\0n\0c\0h\0O\0p\0t\0i\0o\0n\0s") + i];
                }
                for (int i = 0; i < 71; i++)
                {
                    if (Getstr[Getstr.IndexOf("-") - 16 + i] == '\0') continue;
                    Getguid = Getguid + Getstr[Getstr.IndexOf("-") - 16 + i];
                }
                Label.Text = "正在检查更新中（正在连接 advancedfx/xml）";
                XmlDocument back = GetXml("https://www.advancedfx.org/update/61b65ac26b714c41a1d998af3c5bd6dd.xml");
                string version = Get("https://yellowfisher.top/hlaedownload/Getversion.php?Guid=" + Getguid);
                if(version == "No")
                {
                    version = "未登记版本";
                }
                string versionUp = Get("https://yellowfisher.top/hlaedownload/Getversion.php?Guid=" + back.GetElementsByTagName("guid")[0].InnerText);
                if (versionUp == "No")
                {
                    versionUp = "未登记版本";
                }
                //back.GetElementsByTagName("guid");
                if (Getguid == back.GetElementsByTagName("guid")[0].InnerText)
                {
                    Label.Text = "GUID一致\n已是最新版本\n当前版本为：" + version;
                }
                if (Getguid != back.GetElementsByTagName("guid")[0].InnerText)
                {
                    Label.Text = "GUID不一致\n发现新版本：" + versionUp  + "\n当前版本为：" + version;
                }
            }
            catch (Exception error)
            {
                if (error.GetType().ToString() == "System.IO.FileNotFoundException")
                {
                    MessageBox.Show("未找到HLAE.exe\n请将该工具放置到HLAE.exe旁", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(0);
                };
                MessageBox.Show(error.ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }

        public static XmlDocument GetXml(string Url)
        {
            XmlDocument xml = new XmlDocument();
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreComments = true;
            xml.LoadXml(Get(Url));
            return xml;
        }
        public static string Get(string Url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
            request.Method = "GET";
            request.ContentType = "application/x-www-form-urlencoded";
            WebResponse myWebResponse = request.GetResponse();
            Stream ReceiveStream = myWebResponse.GetResponseStream();
            string responseStr = "";
            if (ReceiveStream != null)
            {
                StreamReader reader = new StreamReader(ReceiveStream, Encoding.UTF8);
                responseStr = reader.ReadToEnd();
                reader.Close();
            }
            myWebResponse.Close();
            return responseStr;
        }

        private void GitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/advancedfx/advancedfx/releases/latest");
        }

        private void HlaeChinese_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://hlae.site/topic/394");
        }
    }
}
