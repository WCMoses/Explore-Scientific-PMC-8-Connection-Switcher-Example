using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.IO.Ports;
using System.Threading;
using System.IO;
using System.Net;
using NativeWifi;
using System.Collections.ObjectModel;
using System.Timers;

namespace iExosTest1_1
{
    public class EsMount
    {
        [System.Runtime.InteropServices.DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);

        #region Constants
        const string SERIAL_QUERY = "ESGp0!";
        const string SERIAL_RESPONSE = "ESGp0";

        const string TCP_QUERY = "ESGp0!";
        const string TCP_RESPONSE = "ESGp0";

        const string UDP_QUERY = "ESGp0!";
        const string UDP_RESPONSE = "ESGp0";
        #endregion

        public MountModel MountModel { get; internal set; }
        public delegate void EsNotice(string msg);
        public event EsNotice EsNoticeEvent;



        private string commPort;
        private ConnectionMethod IpProtocol;
        private ConnectionMethod desiredConnectionMethod;
        private int ipPort;


        public ConnectionMethod ConnectionMethod { get; internal set; }

        public string ComPort { get; internal set; }
        public bool Connected { get; internal set; }
        public string IpAddress { get; internal set; }
        public string IpPort { get; internal set; }

        public string ConnectedSsid
        {
            get
            {
                return GetConnectedSsid();
            }
        }
        public bool IsConnectedToWirelessNetwork
        {
            get
            {
                int desc;
                bool result = InternetGetConnectedState(out desc, 0);
                RaiseIoComsEvent("Connected to wireless network: " + result.ToString());
                return result;
            }
        }
        public string ConnectedSsidName
        {
            get
            {
                return GetConnectedSsid();
            }
        }

        public ConnectionMethod DesiredConnectionMethod
        {
            get { return desiredConnectionMethod; }
            internal set { desiredConnectionMethod = value; }
        }

        //                     CONSTRUCTORS
        public EsMount(MountModel model, string commPort)
        {
            if (commPort == "")
            {
                throw new ApplicationException("Mount must have valid com port.");
            }
            //For creating with a serial connection
            this.MountModel = model;
            this.ComPort = commPort;
            this.DesiredConnectionMethod = ConnectionMethod.Serial;
        }

        public EsMount(MountModel model, ConnectionMethod ipProtocol, string ipAddress, int ipPort)
        {
            //For creating withTCP or UDP
            this.MountModel = model;
            DesiredConnectionMethod = ipProtocol;
            this.IpProtocol = ipProtocol;
            IpAddress = ipAddress;
            this.IpPort = ipPort.ToString();
        }
        /// <summary>
        /// /////////////////////////////////////////////////////////////////////////////////
        /// </summary>

        //                          PUBLIC METHODS
        public void Connect()  //Tests connection and sets connected=true
        {
            bool con = false;

            switch (DesiredConnectionMethod)
            {
                case ConnectionMethod.Serial:
                    con = IsConnectedViaSerial();
                    break;
                case ConnectionMethod.TCP:
                    con = IsConnectedViaTcp();
                    break;
                case ConnectionMethod.UDP:
                    con = IsConnectedViaUdp();
                    break;
                default:
                    break;
            }
            if (con == false)
            {
                //throw new Exception("Can not verify connection");
                this.Connected = false;
            }
            RaiseIoComsEvent("Connected to mount.");
            this.Connected = true;
        }

        #region OLD
        //public void ChangeConnectionMethod(ConnectionMethod ipProtocol, string ipAddess, int ipPort)
        //{
        //    //Changes from TCP <--> UDP and Serial -->TCP/UDP
        //    //Can not switch TCP TCP <--> UDP If
        //        //No wireless connection
        //        //No PMC Wireless Connection
        //        //Currently connected via serial
        //    throw new NotImplementedException();
        //}

        //public void ChangeConnectionMethod(ConnectionMethod serial, string serialPort)
        //{
        //    //CHanges from TCP/UDP to Serial
        //    if (ConnectionMethod == ConnectionMethod.TCP)
        //    {
        //        try
        //        {
        //            TcpSendMessage(" switch to serial  ");
        //        }
        //        catch (Exception ex)
        //        {

        //            throw new ApplicationException("Can not change connection method from TCP to serial", ex);
        //        }
        //        ConnectionMethod = ConnectionMethod.Serial;
        //        ComPort = serialPort;
        //    }
        //    if (ConnectionMethod == ConnectionMethod.UDP)
        //    {
        //        try
        //        {
        //            UdpSendMessage(" switch to serial    ");
        //        }
        //        catch (Exception ex)
        //        {

        //            throw new ApplicationException("Can not change connection method from UDP to serial", ex);
        //        }
        //        ConnectionMethod = ConnectionMethod.Serial;
        //        ComPort = serialPort;
        //    }
        //    if (ConnectionMethod == ConnectionMethod.Serial)
        //    {
        //        throw new ApplicationException("Can not change connection method from serial to serial");
        //    }

        //}
        #endregion
        #region ChangeConnectionMethods

        public bool SwitchToSerial(string port)
        {
            if (port == "") { throw new ApplicationException("Com port can not be empty"); }
            //1. If a serial port exists
            //2. If on UDP  --> toggle to TCP
            //3. Switch from TCP -->Serial
            //4. Verify
            //5. Save result to ASCOM

            bool result = false;
            var ports = SerialPort.GetPortNames().GetLength(0);
            if (ports > 0)
            {
                if (ConnectionMethod == ConnectionMethod.UDP)
                {
                    SendRawCommand("ESY!");
                    ConnectionMethod = ConnectionMethod.TCP;
                }
                SendRawCommand("ESX!");
                ConnectionMethod = ConnectionMethod.Serial;
                ComPort = port;
                result = IsConnectedViaSerial();
            }
            return result;
        }
        public bool SwitchToTCP(string ipAddr, string port)
        {
            //If Wireless connection exists
            //if SSID is PMC
            //If Is Currently Serial
            //ESX
            //If is currently UDP
            //ESY
            //Verify
            //Save result to ascom

            bool result = false;
            if (IsConnectedToWirelessNetwork)
            {
                if (ConnectedSsidName.Contains("PMC"))
                {
                    if (ConnectionMethod == ConnectionMethod.Serial)
                    {
                        SendRawCommand("ESX!");
                    }
                    if (ConnectionMethod == ConnectionMethod.UDP)
                    {
                        SendRawCommand("ESY!");
                    }
                    this.IpAddress = ipAddr;
                    this.IpPort = port;
                    result = IsConnectedViaTcp();
                    if (result)
                    {
                        this.ConnectionMethod = ConnectionMethod.TCP;
                        return true;
                    }
                }
            }
            return false;
        }
        public bool SwitchToUDP(string ipAddr, string port)
        {
            //If wireless connection exists
            //if SSID is PMC
            //if Is Currently Serial
            // ESX, ESY
            //If is currently TCP
            //ESY
            //Verify
            //Save result to ascom

            bool result = false;
            if (IsConnectedToWirelessNetwork)                    //If wireless connection exists
            {
                if (ConnectedSsidName.Contains("PMC"))           //if SSID is PMC
                {
                    if (ConnectionMethod == ConnectionMethod.Serial)    //if Is Currently Serial
                    {
                        //esx
                        SerialSendMessage("ESX!");
                        if (MountModel == MountModel.iExos100)
                        {
                            //esy
                            TcpSendMessage("ESY!");
                        }
                    }
                    if (ConnectionMethod == ConnectionMethod.TCP)
                    {
                        //ESY
                        TcpSendMessage("ESY!");
                    }
                    this.IpAddress = ipAddr;
                    this.IpPort = port;
                    result = IsConnectedViaTcp();
                    if (result)
                    {
                        this.ConnectionMethod = ConnectionMethod.UDP;
                        return true;
                    }
                }
            }
            return false;
        }
        #endregion

        #region Coms Methods
        public void SendRawCommand(string cmd)
        {
            if (Connected != true)
            {
                //throw new ApplicationException("Mount must be connected before sending a command to it.");
                RaiseIoComsEvent("ERROR - Mount must be connected before sending a command to it.");
            }
            switch (this.ConnectionMethod)
            {
                case ConnectionMethod.Serial:
                    SerialSendMessage(cmd);
                    break;
                case ConnectionMethod.TCP:
                    TcpSendMessage(cmd);
                    break;
                case ConnectionMethod.UDP:
                    UdpSendMessage(cmd);
                    break;
                default:
                    break;
            }
        }
        public string TcpSendMessage(string command)
        {
            RaiseIoComsEvent("TCP Sending: " + command);
            string message;
            try
            {
                // Create TCP client and connect
                using (var _client = new TcpClient(this.IpAddress, Convert.ToInt32(this.IpPort)))
                using (var _netStream = _client.GetStream())
                {
                    _netStream.ReadTimeout = 2000;

                    // Write a message over the socket
                    message = command + Environment.NewLine;
                    byte[] dataToSend = System.Text.Encoding.ASCII.GetBytes(message);
                    _netStream.Write(dataToSend, 0, dataToSend.Length);
                    Thread.Sleep(500);
                    // Read server response
                    byte[] recvData = new byte[256];
                    int bytes = _netStream.Read(recvData, 0, recvData.Length);
                    message = System.Text.Encoding.ASCII.GetString(recvData, 0, bytes);
                    Console.WriteLine(string.Format("IP Server: {0}", message));
                    RaiseIoComsEvent("Recieved: " + message);
                };// The client and stream will close as control exits the using block (Equivilent but safer than calling Close();
            }
            catch (System.Net.Sockets.SocketException ex)
            {
                RaiseIoComsEvent("ERROR: " + ex.ToString());
                throw new ApplicationException("Can not read/write TCP command", ex);
            }
            RaiseIoComsEvent("TCP Received: " + message);
            return message;
        }

        public string SerialSendMessage(string command)
        {
            if (this.ComPort == null)
            {
                throw new ApplicationException("Serial Port is not set. Can not send message");
            }
            RaiseIoComsEvent("Serial Sending: " + command);
            string newData;
            try
            {
                SerialPort Port = new SerialPort(this.ComPort, 115200, Parity.None, 8);
                Port.Open();
                Port.WriteLine(command);
                Thread.Sleep(500);
                newData = Port.ReadExisting().ToString();
                Console.WriteLine(newData);
                Port.Close();
            }
            catch (Exception ex)
            {

                throw new ApplicationException("Could not send or recieve serial communications", ex);
            }
            RaiseIoComsEvent("TCP Received: " + newData);
            return newData;
        }

        public string UdpSendMessage(string command)
        {
            try
            {
                //SENDER
                UdpSender sender = new UdpSender(IpAddress, ipPort.ToString());  //TODO: correct values

                //RECEIVER

                UdpClient udpClient = new UdpClient();

                udpClient.Client.Bind(new IPEndPoint(IPAddress.Any, ipPort));
                var from = new IPEndPoint(0, 0);
                string msg = "No data received via UDP";

                //SEND/RECEIVE
                RaiseIoComsEvent("Sending: " + command);
                sender.SendMessage(command);

                //Receive
                var timeToWait = TimeSpan.FromSeconds(2);

                //var udpClient = new UdpClient(portNumber);
                var asyncResult = udpClient.BeginReceive(null, null);
                asyncResult.AsyncWaitHandle.WaitOne(timeToWait);
                if (asyncResult.IsCompleted)
                {
                    try
                    {
                        IPEndPoint remoteEP = null;
                        byte[] receivedData = udpClient.EndReceive(asyncResult, ref remoteEP);
                        // EndReceive worked and we have received data and remote endpoint
                        msg = Encoding.UTF8.GetString(receivedData);
                    }
                    catch (Exception ex)
                    {
                        // EndReceive failed and we ended up here
                    }
                }
                else
                {
                    // The operation wasn't completed before the timeout and we're off the hook
                }
                /////////

                //var recvBuffer = udpClient.Receive(ref from);
                //msg = Encoding.UTF8.GetString(recvBuffer);
                RaiseIoComsEvent("Recieved: " + msg);
                return msg;
            }
            catch (Exception ex)
            {
                RaiseIoComsEvent("ERROR: " + ex.ToString());
                throw new ApplicationException("Can not send/receive UDP message.", ex);
            }

        }
        #endregion

        /// /////////////////////////////////////////////////////////////////////////////

        //                          PRIVATE METHODS
        #region Events    


        public void RaiseIoComsEvent(string msg)
        {
            if (EsNoticeEvent != null)
                EsNoticeEvent(msg);
        }


        #endregion

        #region IsCOnnectedViaXXX
        public bool IsConnectedViaUdp()
        {
            RaiseIoComsEvent("Checking UDP connection");
            //Check Wireless first
            if (!IsConnectedToWirelessNetwork)
            {
                RaiseIoComsEvent("No UDP connection detected");
                return false;
            }
            if (!ConnectedSsid.Contains("PMC"))
            {
                RaiseIoComsEvent("No UDP connection detected");
                return false;
            }
            bool versionGood = false;
            try
            {
                string result = UdpSendMessage(UDP_QUERY);
                versionGood = result.Contains(UDP_RESPONSE);
                RaiseIoComsEvent("UDP Connection: " + result.ToString());
                return versionGood;
            }
            catch (Exception ex)
            {

                throw new ApplicationException("IsConnectedViaWifi error", ex);
            }

        }

        public bool IsConnectedViaTcp()
        {
            RaiseIoComsEvent("Checking TCP connection");
            //Check Wireless first
            if (!IsConnectedToWirelessNetwork)
            {
                RaiseIoComsEvent("No TCP connection detected");
                return false;
            }
            if (!ConnectedSsid.Contains("PMC"))
            {
                RaiseIoComsEvent("No PMC-8 network connection detected");
                return false;
            }
            bool versionGood = false;
            try
            {
                string result = TcpSendMessage(TCP_QUERY);
                versionGood = result.Contains(TCP_RESPONSE);
                RaiseIoComsEvent("TCP Connection: " + result.ToString());
                return versionGood;
            }
            catch (Exception ex)
            {
                
                throw new ApplicationException("IsConnectedViaTcp error", ex);
               
            }

        }

        public bool IsConnectedViaSerial()
        {
            RaiseIoComsEvent("Checking SERIAL connection");
            string[] ports = SerialPort.GetPortNames();
            if (ports.Rank > 0 && this.ComPort != null)
            {
                bool versionGood;
                try
                {
                    string result = SerialSendMessage(SERIAL_QUERY);
                    versionGood = result.Contains(SERIAL_RESPONSE);
                    RaiseIoComsEvent("SERIAL Connection: " + result.ToString());
                }
                catch (Exception ex)
                {

                    throw new ApplicationException("IsConnectedViaSerial error", ex);
                }

                return versionGood;

            }
            else
            {
                return false;
            }
        }

        public static EsMount GetConnectedMount(MountModel model, string ipAddress, Int32 ipPort)
        {
            //If wifi Connected
            //If PMC SSID
            //If TCP  --> Return TCP connected mount
            //if UDP --> Return UDP connected mount
            //if Serial ports exist
            //Try Each serial port -->return serial connected mount

            EsMount tcpMount = new EsMount(model, ConnectionMethod.TCP, ipAddress, ipPort);
            if (tcpMount.IsConnectedViaTcp())
            {
                tcpMount.ConnectionMethod = ConnectionMethod.TCP;
                return tcpMount;
            }

            EsMount udpMount = new EsMount(model, ConnectionMethod.UDP, ipAddress, ipPort);
            if (tcpMount.IsConnectedViaUdp())
            {
                udpMount.ConnectionMethod = ConnectionMethod.UDP;
                return udpMount;
            }

            EsMount serialMount = null;
            foreach (var item in SerialPort.GetPortNames())
            {
                serialMount = new EsMount(model, item);
                if (serialMount.IsConnectedViaSerial())
                {
                    serialMount.ConnectionMethod = ConnectionMethod.Serial;
                    return serialMount;
                }
            }
            return null;

        }
        #endregion

        #region WiFi Detection
        private static WlanClient _wlan = new WlanClient();
        public static string GetConnectedSsid()
        {
            Mutex mut = new Mutex();


            //WlanClient wlan = null;
            Collection<String> connectedSsids = new Collection<string>();
            string last = "Not set";
            try
            {
                mut.WaitOne();
                //wlan = new WlanClient();
                if (_wlan.Interfaces != null)
                {
                    foreach (WlanClient.WlanInterface wlanInterface in _wlan.Interfaces)
                    {
                        Wlan.Dot11Ssid ssid = wlanInterface.CurrentConnection.wlanAssociationAttributes.dot11Ssid;
                        connectedSsids.Add(new String(Encoding.ASCII.GetChars(ssid.SSID, 0, (int)ssid.SSIDLength)));
                        last = new String(Encoding.ASCII.GetChars(ssid.SSID, 0, (int)ssid.SSIDLength));
                    }
                }
                //wlan = null;
            }
            catch (Exception)
            {
                throw new ApplicationException("GetConnectedSsid Failed");
            }
            finally
            { mut.ReleaseMutex(); }

            return last;

            //RaiseIoComsEvent("Getting SSID...");
            //System.Diagnostics.Process p = new System.Diagnostics.Process();
            //p.StartInfo.FileName = "netsh.exe";
            //p.StartInfo.Arguments = "wlan show interfaces";
            //p.StartInfo.UseShellExecute = false;
            //p.StartInfo.RedirectStandardOutput = true;
            //p.Start();
            //string s;
            //string s1;
            //try
            //{
            //    s = p.StandardOutput.ReadToEnd();
            //    s1 = s.Substring(s.IndexOf("SSID"));
            //    s1 = s1.Substring(s1.IndexOf(":"));
            //    s1 = s1.Substring(2, s1.IndexOf("\n")).Trim();

            //    string s2 = s.Substring(s.IndexOf("Signal"));
            //    s2 = s2.Substring(s2.IndexOf(":"));
            //    s2 = s2.Substring(2, s2.IndexOf("\n")).Trim();
            //}
            //catch (Exception ex)
            //{
            //    //RaiseIoComsEvent("SSID: Not a PMC-8 SSID.");
            //    s1 = "Not Connected";
            //}


            ////labelStatus.Text = "WIFI connected to " + s1 + "  " + s2;
            //p.WaitForExit();
            ////RaiseIoComsEvent("SSID: s1");
            //return s1;
        }
        #endregion
        ///////////////////////////////////////////////////////////////////////////////////

    }

    public enum ConnectionMethod
    {
        Serial = 1,
        TCP = 2,
        UDP = 3
    }
    public enum MountModel
    {
        iExos100 = 1,
        G11 = 2,
        Exos2
    }
}
