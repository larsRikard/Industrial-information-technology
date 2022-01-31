///////////////////////////////////////////////////////////////////////////////////////////
///
/// PingAppConsole: application testing the ping() connection to a node
///
/// Based on code form Microsoft MSDN about the ping() command
///
/// Version: 1.1: 28-JAN-22: LRR
///
///////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using System.Net.NetworkInformation;
//
namespace PingAppConsole
{
    class Program
    {
        /// <summary>
        /// //////////////////////////////////////////////////////////////////////////////
        static void Main(string[] args)
        ///
        /// Purpose: the main function in the application handling the ping()communication
        ///
        /// Version: 1.1: 28-JAN-22: LRR
        /// </summary>
        {
            string host, data;
            byte[] buffer;
            int timeout;
            Ping pingSender = new Ping();
            PingOptions options = new PingOptions();

            // Use the default Ttl value which is 128,
            // but change the fragmentation behavior.
            options.DontFragment = true;
            // Create a buffer of 32 bytes of data to be transmitted.
            data = "UniversityCollegeofSouthEastNorw";
            buffer = Encoding.ASCII.GetBytes(data);
            timeout = 120;
            // Name or address of node to access
            host = "10.0.0.14";
            PingReply reply = pingSender.Send(host, timeout, buffer, options);
            if (reply.Status == IPStatus.Success)
            {
                Console.WriteLine(" Ping communication status for {0}:", host);
                Console.WriteLine(" ------------------------------------------");
                Console.WriteLine(" Address: {0}", reply.Address.ToString());
                Console.WriteLine(" RoundTrip time (mSec): {0}", reply.RoundtripTime);
                Console.WriteLine(" Time to live: {0}", reply.Options.Ttl);
                Console.WriteLine(" Don't fragment: {0}", reply.Options.DontFragment);
                Console.WriteLine(" Buffer size: {0}", reply.Buffer.Length);
                Console.WriteLine(" ------------------------------------------");
            }
            else
            {
                Console.WriteLine(" Error connecting to network address/name {0}", host);
            }
            Console.WriteLine(" Press CR or Enter to Quit the application");
            Console.ReadLine();
        }
    }
}
///
////////////////////////////////////////////////////////////////////////////////////////