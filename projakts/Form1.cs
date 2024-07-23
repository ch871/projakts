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
using System.Xml;

namespace projakts
{
    public partial class Form1 : Form
    {
        XmlDocument xmlDocument = new XmlDocument();
        string pathString = Directory.GetCurrentDirectory() + "\\projekts.xml";
        public Form1()
        {
            InitializeComponent();

            if (File.Exists(pathString))
            {
                xmlDocument.Load(pathString);
            }
            else 
            {
                XmlNode root = xmlDocument.CreateElement("projeks");
                xmlDocument.AppendChild(root);
                xmlDocument.Save(pathString);
            }
            ShowAllProjekts();
        }


        private void btnEnterProjekt_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || cmbLanguich.Text == "")
            {
                MessageBox.Show("לא הכנסת שם או שפה");
                return;
            }
            foreach (XmlNode pro in xmlDocument.FirstChild.ChildNodes)
            {
                if (pro.FirstChild.InnerText == txtName.Text)
                {
                    MessageBox.Show("יש כבר פרויקט בשם הזה");
                    return;
                }
            }
                XmlNode projekt = xmlDocument.CreateElement("projekt");
            projekt.AppendChild(xmlDocument.CreateElement("name")).InnerText = txtName.Text;
            projekt.AppendChild(xmlDocument.CreateElement("time")).InnerText = dtpTime.Value.ToString();
            projekt.AppendChild(xmlDocument.CreateElement("languich")).InnerText = cmbLanguich.Text;
            xmlDocument.FirstChild.AppendChild(projekt);

            xmlDocument.Save(pathString);
            ShowAllProjekts();
            cleer();
        }
        private void ShowAllProjekts()
        {
            dgvShowProjekts.Rows.Clear();
            foreach(XmlNode projekt in xmlDocument.FirstChild.ChildNodes)
            {
                string name = "", time = "", languich = "";
                foreach(XmlNode node in projekt.ChildNodes)
                {
                    switch (node.Name) 
                    {
                        case "name":
                            name = node.InnerText;break;
                        case "time": 
                            time = node.InnerText; break;
                        case "languich":
                            languich = node.InnerText; break;
                    }
                }
                dgvShowProjekts.Rows.Add(name, time, "מחיקת שורה", languich);
            }
        }
        private void cleer()
        {
            txtName.Text = "";
            cmbLanguich.Text = "";
            dtpTime.Value = DateTime.Now;
        }


        private void dgvShowProjekts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            if (dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
               string x = dgvShowProjekts.Rows[e.RowIndex].Cells[0].Value.ToString();
                
                foreach (XmlNode xmlNode in xmlDocument.FirstChild.ChildNodes) 
                {                
                    if (xmlNode.FirstChild.InnerText == x)
                    {
                      xmlDocument.FirstChild.RemoveChild(xmlNode);
                    }
                }
            }
            ShowAllProjekts();
        }
    }
}
