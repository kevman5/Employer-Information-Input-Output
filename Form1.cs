using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Project_XML01
{
    public partial class Form1 : Form
    {
        private string xmldData;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XElement rootElement = new XElement("Company_Information");
            rootElement.Add(new XElement("Kevin"));
            rootElement.Add(new XElement("Ashley"));
            rootElement.Add(new XElement("Ponca_City"));
            rootElement.Add(new XElement("Mckinley"));


            rootElement.Save("c:\\");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string xmldata = @" <rootElement>
                               </RootElement>" ;
            XDocument info1 = new XDocument();
            info1 = XDocument.Parse(xmldData);
            var xml = (from p in info1.Elements()
                       select p).ToList();
            foreach (var item in xml)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
