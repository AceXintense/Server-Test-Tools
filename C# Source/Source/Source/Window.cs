using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Source
{
    public partial class Window : Form
    {
        public string IPTemp = "localhost";
        public string DataTemp = "10";
        public string ReqTemp = "10";
        public Window()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for Using Server Test Toolkit By AceXintense", "Thanks", MessageBoxButtons.OK);
        }

        private void IP_TextChanged(object sender, EventArgs e)
        {
            IPTemp = IP.Text;
        }

        private void DataPacket_TextChanged(object sender, EventArgs e)
        {
            DataTemp = DataPacket.Text;
        }

        private void AmmountRequests_TextChanged(object sender, EventArgs e)
        {
            ReqTemp = AmmountRequests.Text;
        }

        private void Ping_Click(object sender, EventArgs e)
        {
            if (IPTemp != "" && int.Parse(DataTemp) > 0 && int.Parse(ReqTemp) > 0 && UnReq.Checked == false)
            {
                RunCommandCom("Ping ", IPTemp, DataTemp, ReqTemp);
            }
            if (IPTemp != "" && int.Parse(DataTemp) > 0 && UnReq.Checked == true)
            {
                RunCommandComUn("Ping ", IPTemp, DataTemp);
            }
            if (IPTemp == "" && int.Parse(DataTemp) > -1 && int.Parse(ReqTemp) > -1 && UnReq.Checked == false)
            {
                MessageBox.Show("Please Set a IP and Packet Size and Set the Ammount of Requests", "Error", MessageBoxButtons.OK);
            }
            if (IPTemp == "" && int.Parse(DataTemp) > -1 && int.Parse(ReqTemp) > -1 && UnReq.Checked == true)
            {
                MessageBox.Show("Please Set a IP and Packet Size", "Error", MessageBoxButtons.OK);
            }
            if (IPTemp == "")
            {
                MessageBox.Show("Please Set a IP", "Error", MessageBoxButtons.OK);
            }
            if (int.Parse(DataTemp) == 0)
            {
                MessageBox.Show("Please Set Packet Size Larger Than 0", "Error", MessageBoxButtons.OK);
            }
            if (int.Parse(ReqTemp) == 0 && UnReq.Checked == false)
            {
                MessageBox.Show("Please Set Request Size Larger Than 0", "Error", MessageBoxButtons.OK);
            }
            
        }

        public void RunCommandCom(string command, string arguments, string packetSize, string requestAmmount)
        {
            if(IPv4.Checked == true){
                Process p = new Process();
                ProcessStartInfo pi = new ProcessStartInfo();
                pi.Arguments = " " + "/K" + " " + command + arguments + " -l " + packetSize + " -4 " + " -n " + requestAmmount;
                pi.FileName = "cmd.exe";
                p.StartInfo = pi;
                p.Start();
            }
            else
            {
                Process p = new Process();
                ProcessStartInfo pi = new ProcessStartInfo();
                pi.Arguments = " " + "/K" + " " + command + arguments + " -l " + packetSize + " -6 " + " -n " + requestAmmount;
                pi.FileName = "cmd.exe";
                p.StartInfo = pi;
                p.Start();
            }
        }
        public void RunCommandComUn(string command, string arguments, string packetSize)
        {
            if (IPv4.Checked == true)
            {
                Process p = new Process();
                ProcessStartInfo pi = new ProcessStartInfo();
                pi.Arguments = " " + "/K" + " " + command + arguments + " -l " + packetSize + " -4 " + " -t ";
                pi.FileName = "cmd.exe";
                p.StartInfo = pi;
                p.Start();
            }
            else
            {
                Process p = new Process();
                ProcessStartInfo pi = new ProcessStartInfo();
                pi.Arguments = " " + "/K" + " " + command + arguments + " -l " + packetSize + " -6 " + " -t ";
                pi.FileName = "cmd.exe";
                p.StartInfo = pi;
                p.Start();
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            IPTemp = "localhost";
            DataTemp = "10";
            ReqTemp = "10";
            DataPacket.Text = "10";
            IP.Text = "localhost";
            AmmountRequests.Text = "10";
            IPv4.Checked = true;
            IPv6.Checked = false;
            UnReq.Checked = false;

        }

        private void UnReq_CheckedChanged(object sender, EventArgs e)
        {
            if (UnReq.Checked == true)
            {
                AmmountRequests.Enabled = false;
            }
            if(UnReq.Checked == false)
            {
                AmmountRequests.Enabled = true;
            }
        }

        private void IPv4_CheckedChanged(object sender, EventArgs e)
        {
            if(IPv4.Checked == true){
                IPv6.Checked = false;

            }

        }

        private void IPv6_CheckedChanged(object sender, EventArgs e)
        {
            if (IPv6.Checked == true)
            {
                IPv4.Checked = false;

            }
        }
    }
}
