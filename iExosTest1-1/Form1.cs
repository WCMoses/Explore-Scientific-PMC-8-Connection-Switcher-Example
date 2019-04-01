using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace iExosTest1_1
{
    public partial class Form1 : Form
    {
        public delegate void WiFiDelegate(string msg);
        public event WiFiDelegate WiFiEvent;
        private System.Timers.Timer wifiTimer;
        private int _pollingSpeed = 0;
        public int WiFiPollingSpeed
        {
            get
            { return _pollingSpeed; }
            set
            {
                _pollingSpeed = value;

                if (_pollingSpeed > 0)
                {
                    wifiTimer = new System.Timers.Timer(_pollingSpeed);
                    wifiTimer.Elapsed += OnTimedEvent;
                    wifiTimer.Start();
                }
                else
                {
                    wifiTimer.Stop();
                }

            }
        }

        private int lineCount;

        EsMount _mount = null;
        public EsMount Mount
        {
            get { return _mount; }
            set
            {
                _mount = value;
                if (value != null)
                {
                    Dump("Connection Method Changed To: " + value.ConnectionMethod.ToString());
                    value.EsNoticeEvent += Dump;
                }

            }
        }
        public Form1()
        {
            InitializeComponent();
            foreach (string s in System.IO.Ports.SerialPort.GetPortNames())
            {
                cmbBasic2SerialPort.Items.Add(s);
            }
            cmbBasic2MountType.SelectedIndex = 1;
            tabControl1.TabPages.Remove(tpAdvanced);  //Hide unless checkbox is checked
            WiFiPollingSpeed = 1000;
        }

        //private void Form1_WiFiEvent(string msg)
        //{
        //    string ssid = EsMount.GetConnectedSsid();
        //    tsCurrentWiFi.Text = ssid;
        //}

        //private void Mount_WiFiEvent(string msg)
        //{
        //    tsCurrentWiFi.Text = msg;
        //}

        #region GUI Related
        public void Dump(string msg)
        {

            txtOutput.Text += lineCount.ToString() + ":  " + msg + Environment.NewLine;
            lineCount++;
        }

        #endregion

        #region Advanced tab
        //private void cmdSendCustomCommand_Click(object sender, EventArgs e)
        //{
        //    EsMount mount = CreateMountObject();
        //    mount.IoComsEvent += Dump;
        //    try
        //    {
        //        mount.Connect();

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Can not connect to mount.  Please check settings");
        //    }
        //    mount.SendRawCommand(txtCommandToSend.Text);
        //}

        #region Basic Tab Switch Option
        //private void cmdEsToWirelessAscom_Click(object sender, EventArgs e)
        //{
        //    EsMount mount = CreateMountObject();
        //    try
        //    {
        //        mount.Connect();
        //        mount.IoComsEvent += Dump;
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("Can not connect to mount.  Please check settings");
        //    }
        //    mount.SendRawCommand("ESY!");
        //}

        //private void cmdEsToWiredAscom_Click(object sender, EventArgs e)
        //{
        //    EsMount mount = CreateMountObject();
        //    try
        //    {
        //        mount.Connect();
        //        mount.IoComsEvent += Dump;
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("Can not connect to mount.  Please check settings");
        //    }
        //    mount.SendRawCommand("ESY!");
        //    mount.SendRawCommand("ESX!");
        //}

        //private void cmdSerialToWirelessEs_Click(object sender, EventArgs e)
        //{
        //    EsMount mount = CreateMountObject();
        //    try
        //    {
        //        mount.Connect();
        //        mount.IoComsEvent += Dump;
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("Can not connect to mount.  Please check settings");
        //    }
        //    mount.SendRawCommand("ESX!");
        //}

        //private void cmdSerialToWirelessAscom_Click(object sender, EventArgs e)
        //{
        //    EsMount mount = CreateMountObject();
        //    try
        //    {
        //        mount.Connect();
        //        mount.IoComsEvent += Dump;
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("Can not connect to mount.  Please check settings");
        //    }
        //    mount.SendRawCommand("ESX!");
        //}
        #endregion

        #region Serial buttons


        #endregion

        #region TCP Buttons
        //private void cmdTcpUdp_Click(object sender, EventArgs e)
        //{
        //    MountModel m = (MountModel)Enum.Parse(typeof(MountModel), cmbMount.SelectedItem.ToString());
        //    EsMount mount = new EsMount(m, ConnectionMethod.TCP, txtIpAddr.Text, Convert.ToInt16(txtIpPort.Text));
        //    mount.IoComsEvent += Dump;

        //}

        //private void cmdTcpSerial_Click(object sender, EventArgs e)
        //{
        //    MountModel m = (MountModel)Enum.Parse(typeof(MountModel), cmbMount.SelectedItem.ToString());
        //    EsMount mount = new EsMount(m, ConnectionMethod.TCP, txtIpAddr.Text, Convert.ToInt16(txtIpPort.Text));
        //    mount.IoComsEvent += Dump;

        //}


        #endregion
        #endregion
        #region CreateMountObject
        //private EsMount CreateMountObject()
        //{
        //    Dump("Creating mount object.");
        //    MountModel m = (MountModel)Enum.Parse(typeof(MountModel), cmbMount.SelectedItem.ToString());
        //    EsMount mount = null;
        //    bool mountSet = false;
        //    if (cmbPort.Text == "TCP")
        //    {
        //        mount = new EsMount(m, ConnectionMethod.TCP, txtIpAddr.Text, Convert.ToInt32(txtIpPort.Text));
        //        mountSet = true;
        //    }
        //    if (cmbPort.Text == "UDP")
        //    {
        //        mount = new EsMount(m, ConnectionMethod.UDP, txtIpAddr.Text, Convert.ToInt32(txtIpPort.Text));
        //        mountSet = true;
        //    }
        //    if (cmbPort.Text.Contains("COM"))
        //    {
        //        mount = new EsMount(m, cmbPort.Text);
        //        mountSet = true;
        //    }
        //    if (!mountSet)
        //    {
        //        throw new ApplicationException("Can not create mount.  Please check Current Settings.");
        //    }
        //    return mount;
        //}
        #endregion

        private void cmdDetails_Click(object sender, EventArgs e)
        {
            if (txtOutput.Visible)
            {
                txtOutput.Visible = false;
            }
            else
            {
                txtOutput.Visible = true;
            }
        }


        #region Misc Old Stuff
        //private void cmbPort_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cmbPort.Text == "TCP" || cmbPort.Text == "UDP")
        //    {
        //        //MessageBox.Show("Please make sure you are on the PMC-8 network.");
        //        MountModel m = (MountModel)Enum.Parse(typeof(MountModel), cmbMount.SelectedItem.ToString());
        //        EsMount mount = new EsMount(m, ConnectionMethod.UDP, txtIpAddr.Text, Convert.ToInt32(txtIpPort.Text));
        //        if (!mount.IsConnectedToWirelessNetwork)
        //        {
        //            MessageBox.Show("You do not appear to be connected to a wireless network.");
        //        }
        //        else
        //        {
        //            if (!mount.ConnectedSsidName.Contains("PMC"))
        //            {
        //                MessageBox.Show("You do not appear to be connected to a PMC8 network.");
        //            }
        //        }

        //    }
        //}

        //private void cmdFindConnectionMethod_Click(object sender, EventArgs e)
        //{
        //    EsMount mount = null;
        //    if (cmbPort.SelectedItem.ToString() == "TCP")
        //    {
        //        mount = new EsMount(MountModel.iExos100, ConnectionMethod.TCP, txtIpAddr.Text, Convert.ToInt32(txtIpPort.Text));
        //    }
        //    if (cmbPort.SelectedItem.ToString() == "UDP")
        //    {
        //        mount = new EsMount(MountModel.iExos100, ConnectionMethod.UDP, txtIpAddr.Text, Convert.ToInt32(txtIpPort.Text));

        //    }
        //    if (cmbPort.SelectedItem.ToString().Contains("COM"))
        //    {
        //        mount = new EsMount(MountModel.iExos100, cmbPort.SelectedItem.ToString());
        //    }
        //    if (mount.IsConnectedViaSerial())
        //    {
        //        Dump("Connected via serial");
        //    }
        //    if (mount.IsConnectedViaTcp())
        //    {
        //        Dump("Connected via TCP");
        //    }
        //    if (mount.IsConnectedViaUdp())
        //    {
        //        Dump("Connected via Udp");
        //    }
        //}

        //private void cmdGetConnectedMount_Click(object sender, EventArgs e)
        //{
        //    EsMount mount = EsMount.GetConnectedMount(MountModel.iExos100, txtIpAddr.Text, Convert.ToInt32(txtIpPort.Text));
        //    Console.WriteLine();
        //}
        #endregion


        private void txtIpPort_TextChanged(object sender, EventArgs e)
        {

        }

        public void SetMountFromGui()
        {
            string selectedItem = "";
            MountModel m = MountModel.Exos2;
            string ipAddr = "";
            Int32 ipPort = 0;
            string comPort = "";
            try
            {
                selectedItem = cmbBasic2MountType.SelectedItem.ToString();
                m = (MountModel)Enum.Parse(typeof(MountModel), selectedItem);
                ipAddr = txtBasic2IpAddress.Text;
                ipPort = Convert.ToInt32(txtBasic2IpPort.Text);
                comPort = cmbBasic2SerialPort.Text;
                Mount = EsMount.GetConnectedMount(m, ipAddr, ipPort);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please make sure all settings are valid", "Error");
            }

        }

        private void cmdBasic2ViaAscom_Click(object sender, EventArgs e)
        {
            //1. Determine current connection
            //2. switch to ascom
            if (cmbBasic2MountType.Text == "")
            {
                MessageBox.Show("Please select a mount type", "Error");
                return;
            }
            if (cmbBasic2SerialPort.Text == "")
            {
                MessageBox.Show("Please ensure a port is selected", "Error");
                return;
            }
            string comPort = cmbBasic2SerialPort.Text;

            //1. Determine current connection
            SetMountFromGui();

            //2. switch to ascom
            try
            {
                Mount.SwitchToSerial(comPort);
                MessageBox.Show("Successfully switched to Serial", "Notice");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Can not switch to Serial" + Environment.NewLine + ex.ToString(), "Error");
            }

        }

        private void cmdBasic2ViaTCP_Click(object sender, EventArgs e)
        {
            if (txtBasic2IpAddress.Text=="" || txtBasic2IpPort.Text=="")
            {
                MessageBox.Show("Please make sure your IP address and port are set.", "Error");
            }
            //1. Determine current connection
            //2. switch to TCP

            string ipAddr = txtBasic2IpAddress.Text;
            Int32 ipPort = Convert.ToInt32(txtBasic2IpPort.Text);

            //1. Determine current connection
            SetMountFromGui();

            //2. switch to TCP
            try
            {
                Mount.SwitchToTCP(ipAddr, ipPort.ToString());
                MessageBox.Show("Successfully switched to TCP", "Notice");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not switch to TCP" + Environment.NewLine + ex.ToString(), "Error");

            }

        }

        private void cmdBasic2ViaUdp_Click(object sender, EventArgs e)
        {
            if (txtBasic2IpAddress.Text == "" || txtBasic2IpPort.Text == "")
            {
                MessageBox.Show("Please make sure your IP address and port are set.", "Error");
            }

            //1. Determine current connection
            //2. switch to UDP

            string ipAddr = txtBasic2IpAddress.Text;
            Int32 ipPort = Convert.ToInt32(txtBasic2IpPort.Text);

            //1. Determine current connection
            SetMountFromGui();

            //2. switch to UDP
            try
            {
                Mount.SwitchToUDP(ipAddr, txtBasic2IpPort.Text);
                MessageBox.Show("Successfully switched to UDP", "Notice");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Can not switch to UDP" + Environment.NewLine + ex.ToString(), "Error");
            }

        }

        private void chkShowAdvancedOptions_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowAdvancedOptions.Checked)
            {
                tabControl1.TabPages.Add(tpAdvanced);
            }
            else
            {
                tabControl1.TabPages.Remove(tpAdvanced);
            }
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void cmdBasic2CheckCurrentConnection_Click(object sender, EventArgs e)
        {
            try
            {
                SetMountFromGui();
                tsConnectionMethod.Text = Mount.ConnectionMethod.ToString();
                MessageBox.Show("Your mount appears to be connected by: " + Mount.ConnectionMethod.ToString(), "Connection Type");
            }
            catch (Exception ex)
            {
                string msg = "Your mount connection could not be determined." + Environment.NewLine;
                msg += "Possible causes include" + Environment.NewLine;
                msg += "     1. You are not connected to the PMC-8 network." + Environment.NewLine;
                msg += "     2. A required serial connection is missing" + Environment.NewLine;
                msg += "     3. Information on the left is incorrect" + Environment.NewLine;
                MessageBox.Show(msg, "Error");
            }
        }

        //public void RaiseWiFiEvent(string msg)
        //{
        //    if (WiFiEvent != null)
        //    {
        //        WiFiEvent(msg);
        //    }
        //}

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            string ssid = EsMount.GetConnectedSsid();
            //Console.WriteLine("SSID: " + ssid);
            //RaiseWiFiEvent(ssid);
            tsCurrentWiFi.Text = ssid;
        }

        private void cmdSendCustomCommand_Click(object sender, EventArgs e)
        {
            SendCustomCommand(txtCommandToSend.Text);
        }

        private void SendCustomCommand(string cmd)
        {
            try
            {
                if (rbAutoDetect.Checked)
                {
                    Dump("Sending via Autodetect: " + cmd);
                    Mount.SendRawCommand(cmd);
                }
                if (rbTcp.Checked)
                {
                    Dump("Sending via TCP: " + cmd);
                    Mount.TcpSendMessage(cmd);
                }
                if (rbSerial.Checked)
                {
                    Dump("Sending via Serial: " + cmd);
                    Mount.SerialSendMessage(cmd);
                }
                if (rbUdp.Checked)
                {
                    Dump("Sending via UDP: " + cmd);
                    Mount.UdpSendMessage(cmd);
                }
            }
            catch (Exception ex)
            {
                string msg = "An error has occured. Unable to send command.  Please make sure you have selected the correct Communication Method below" + Environment.NewLine;
                msg += Environment.NewLine + ex.ToString();
                Dump("Error: " + cmd);
                MessageBox.Show(msg, "Error");
            }

        }

        private void cmdAdvancedEsx_Click(object sender, EventArgs e)
        {

            SendCustomCommand("ESX!");
        }

        private void cmdAdvancedESY_Click(object sender, EventArgs e)
        {
            SendCustomCommand("ESY!");
        }

        private void cmdAdvancedEsgp0_Click(object sender, EventArgs e)
        {
            SendCustomCommand("ESGp0!");
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "";
        }
    }
}
