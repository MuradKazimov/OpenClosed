using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenClosed
{
    public partial class Form1 : Form
    {

        private SqlConnection cnctn = new SqlConnection("Server=DESKTOP-HQ54VJP\\SQLEXPRESS01; Database=Northwind; Integrated Security=true;");
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnChangeConnection_Click(object sender, EventArgs e)
        {
            if (cnctn.State == ConnectionState.Open)
            {
                cnctn.Close();
                LblConnectionStatus.Text = "Server is Disconnected";
                BtnChangeConnection.Text = "Connect";

            }
            else
            {
                cnctn.Open();
                LblConnectionStatus.Text = "Server is Connected";
                BtnChangeConnection.Text = "Disconnect";

            }
        }
    }
}
