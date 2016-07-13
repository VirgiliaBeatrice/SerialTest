using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.IO.Ports;

namespace SerialTest
{
    public class SerialPortCommunication
    {
        static void Main(string[] args)

        {
            string rev_data = "";

            SerialPort ser = new SerialPort("COM2", 57600);
            if (ser.IsOpen)
            {
                ser.Close();
            }
            ser.Open();
            Console.WriteLine(ser.IsOpen);
            Console.WriteLine("Start to receiving.\r\n");

            while (true)
            {
                //ser.WriteLine("AAA");
                if (ser.BytesToRead != 0)
                {
                    ser.WriteLine("Received.");

                    rev_data = ser.ReadLine();
                    Console.Write("Receiving: ");
                    Console.WriteLine(rev_data);
                }
            }
        }
    }
}
