using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmTask5
{
    public partial class Task5 : Form
    {
        StdListConverter data;

        public Task5()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    data = new StdListConverter(ofd.FileName, sfd.FileName);
                    data.LoadCs();
                    Print(data);
                    data.SaveXml();
                    btnConvert.Text = "Операция выполнена";
                };
            };
        }

        private void Print(StdListConverter data)
        {
            StringBuilder sb = new StringBuilder();
            for (int i=0;i< data.Count; i++)
            {
                sb.Append(data[i].ToString() + "\r\n\r\n");
            }
            tbInfo.Text = sb.ToString();
        }
    }
}
