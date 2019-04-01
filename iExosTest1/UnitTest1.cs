using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using iExosTest1_1;
using System.Net.Sockets;
using System.IO.Ports;

namespace iExosTest1
{

    [TestClass]
    public class UnitTest1
    {

        //CONNECTION INFO FOR MOUNT
        const string  SERIALPORT = "COM3";
        const string IPADDR = "127.0.0.1";
        const int IPPORT = 1234;

        //SERIAL TESTS

        [TestMethod]
        public void Serial_Connects()  //ASSUMES MOUNT IS ON A SERIAL CONNECTION
        {
            //Arrage
            EsMount mount = new EsMount(commPort: SERIALPORT);
            // SETS mount.ConnectionMethod = ConnectionMethod.Serial;

            //Act
            mount.Connect();

            //Assert
            Assert.IsTrue(mount.Connected == true);
            Assert.IsTrue(mount.ConnectionMethod == ConnectionMethod.Serial);

        }

        [TestMethod]
        public void Serial_ToTCP()
        {
            //Arrage
            EsMount mount = new EsMount(commPort: SERIALPORT);
            // SETS mount.ConnectionMethod = ConnectionMethod.Serial;
            //Act
            mount.Connect();
            mount.ChangeConnectionMethod(ConnectionMethod.TCP, ipAddess: IPADDR, ipPort: IPPORT);

            //Assert
            Assert.IsTrue(mount.Connected == true);
            Assert.IsTrue(mount.ConnectionMethod == ConnectionMethod.TCP);
        }

        [TestMethod]
        public void Serial_ToUDP()
        {
            //Arrage
            EsMount mount = new EsMount(commPort: SERIALPORT);
            // SETS mount.ConnectionMethod = ConnectionMethod.Serial;
            //Act
            mount.Connect();
            mount.ChangeConnectionMethod(ConnectionMethod.UDP, ipAddess: IPADDR, ipPort: IPPORT);

            //Assert
            Assert.IsTrue(mount.Connected == true);
            Assert.IsTrue(mount.ConnectionMethod == ConnectionMethod.UDP);
        }


        //TCP TESTS

        [TestMethod]
        public void Tcp_Connects()
        {
            //Arrage
            EsMount mount = new EsMount(ConnectionMethod.TCP, ipAddress: IPADDR, ipPort: IPPORT);
            //SETS  mount.IpAddress = "127.0.0.0";
            //SETS mount.IpPort = "1234";
            //SETS mount.ConnectionMethod = ConnectionMethod.TCP;

            //Act
            mount.Connect();

            //Assert
            Assert.IsTrue(mount.Connected == true);
            Assert.IsTrue(mount.ConnectionMethod == ConnectionMethod.TCP);
        }

        [TestMethod]
        public void TCP_ToUDP()
        {
            //Arrage
            EsMount mount = new EsMount(ConnectionMethod.TCP, ipAddress:IPADDR, ipPort: IPPORT);

            //Act
            mount.Connect();
            mount.ChangeConnectionMethod(ConnectionMethod.UDP, ipAddess: IPADDR, ipPort: IPPORT);

            //Assert
            Assert.IsTrue(mount.Connected == true);
            Assert.IsTrue(mount.ConnectionMethod == ConnectionMethod.UDP);
        }

        [TestMethod]
        public void TCP_ToSerial()
        {
            //Arrage
            EsMount mount = new EsMount(ConnectionMethod.TCP, ipAddress: IPADDR, ipPort: IPPORT);

            //Act
            mount.Connect();
            mount.ChangeConnectionMethod(ConnectionMethod.Serial,serialPort: SERIALPORT);

            //Assert
            Assert.IsTrue(mount.Connected == true);
            Assert.IsTrue(mount.ConnectionMethod == ConnectionMethod.Serial);
        }

        //UDP TESTS

        [TestMethod]
        public void UDP_Connects()  //ASSUMES MOUNT IS ON A SERIAL CONNECTION
        {
            //Arrage
            EsMount mount = new EsMount(ConnectionMethod.UDP, ipAddress: IPADDR, ipPort: IPPORT);
            //SETS mount.IpAddress = "127.0.0.0";
            //SETS mount.IpPort = "1234";
            //SETS mount.ConnectionMethod = ConnectionMethod.UDP;

            //Act
            mount.Connect();

            //Assert
            Assert.IsTrue(mount.Connected == true);
            Assert.IsTrue(mount.ConnectionMethod == ConnectionMethod.UDP);
        }

        [TestMethod]
        public void UDP_ToSerial()  //ASSUMES MOUNT IS ON A SERIAL CONNECTION
        {
            //Arrage
            EsMount mount = new EsMount(ConnectionMethod.UDP, ipAddress: IPADDR, ipPort: IPPORT);

            //Act
            mount.Connect();
            mount.ChangeConnectionMethod(ConnectionMethod.Serial, serialPort: SERIALPORT);

            //Assert
            Assert.IsTrue(mount.Connected == true);
            Assert.IsTrue(mount.ConnectionMethod == ConnectionMethod.Serial);
        }

        [TestMethod]
        public void UDP_ToTCP()  //ASSUMES MOUNT IS ON A SERIAL CONNECTION
        {
            //Arrage
            EsMount mount = new EsMount(ConnectionMethod.UDP, ipAddress: IPADDR, ipPort: IPPORT);

            //Act
            mount.Connect();
            mount.ChangeConnectionMethod(ConnectionMethod.TCP, IPADDR, ipPort: IPPORT);

            //Assert
            Assert.IsTrue(mount.Connected == true);
            Assert.IsTrue(mount.ConnectionMethod == ConnectionMethod.Serial);
        }

       
    }


}
