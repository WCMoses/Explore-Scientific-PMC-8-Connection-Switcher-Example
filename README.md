# Explore-Scientific-PMC-8-Connection-Switcher-Example
ES PMC-8 Connection Switcher Example
##Purpose
The purpose of the EsMount class is to provide a single class a developer can use for performing almost all common operations on or with PMC-8 mounts via direct PMC-8 commands. The EsMount class does not use ASCOM

_Capabilities_

The EsMount class is capable of:
1.	Determining the connection method (TCP/UDP/Serial) of the mount.
2.	Sending raw PMC-8 commands to the mount via TCP, UDP and serial.
3.	Switching the mount between connection methods.
4.	Raising events to keep the consumer informed of its activities.
5.	Detecting if the computer is connected to a WiFi network.
6.	Detecting if the computer is connected to a PMC-8 access point.

_Creating an Instance_

There are two overloads for creating an EsMount instance:
	public EsMount(MountModel model, string commPort)
public EsMount(MountModel model, ConnectionMethod ipProtocol, string ipAddress, int ipPort)
In each case, pass in the mount model using the MountModel enum and then the required communication connection settings.
Alternatively, you can use the static GetConenctedMount method to return an instance that may have all the correct settings for a mount.  If the mount does not exist or the user is on the wrong network, then the correct setting can not be returned..  You must pass in basic connection information.  For example, you might have a gui that allows the user to select the IP address and port and/or the serial port.  You could pass that information into the method as follows:

	 public void SetMountFromGui()
        {
            string selectedItem = cmbBasic2MountType.SelectedItem.ToString();
            MountModel m = (MountModel)Enum.Parse(typeof(MountModel), selectedItem);
            string ipAddr = txtBasic2IpAddress.Text;
            Int32 ipPort = Convert.ToInt32(txtBasic2IpPort.Text);
            string comPort = cmbBasic2SerialPort.Text;
            Mount = EsMount.GetConnectedMount(m, ipAddr, ipPort);
        }
Notice the parsing of the MountModel enum and the use of Int32 for the port numbers.

Events
The EsMount class raises a number of events related to its activities.  The delegate and event are defined as:
	       public delegate void EsNotice(string msg);
        	public event EsNotice EsNoticeEvent;

You can subscribe to these via:
		EsNoticeEvent += Dump;
Where Dump has the same signature as the EsNotice delegate.
Future versions will allow for discrimination of which events to receive.


_Working with the Wireless Network_

You will frequently want to check to make sure that the user is connected to a network, and a PMC-8 network in particular, before performing operations.  You can check to see if the computer is connected to a wireless network using:

		public bool IsConnectedToWirelessNetwork()

In order to determine which wireless network the computer is connected to use:
		public string ConnectedSsidName
From there you can check to see if the name contains “PMC” to determine if it is a PMC-8 access point:
	if (ConnectedSsid.Contains("PMC"))
            {
                … Do something
            }

Future versions will verify it is a PMC-8 access point by interrogating the network.
This property is just a wrapper around the static GetConnectedSsid method:
		public static string GetConnectedSsid()


_Sending Commands to the Mount_

You can send commands directly to the mount using one of four methods:
	public void SendRawCommand(string cmd)
	public string TcpSendMessage(string command)
	public string SerialSendMessage(string command)
	public string UdpSendMessage(string command)

The first function, SendRawCommand, will attempt to send the message to the mount using it’s current connection method.  If you know how the mount is connected, you can use one of the XXXSendMessage methods.


_Switching Mount Connection Methods_

The EsMount class can issue commands to switch the mount between serial, tcp, and udp. Explore: 
		public bool SwitchToSerial(string port)
		public bool SwitchToTCP(string ipAddr, string port)
		public bool SwitchToUDP(string ipAddr, string port)
In each case, the EsMount class will attempt to determine the mounts current configuration and then issue the commands required to switch it to the desired connection state.
