using System;
using System.Text;
using System.Threading;
using nanoFramework.Hardware.Esp32.Rmt;

namespace IRController
{
    public class Program
    {
        public static void Main()
        {
            var signalDecoder = new NecSignalDecoder(signalLengthTolerance:0.25);
            InfraredListener listener = new InfraredListener(33);
            listener.SignalEvent += (sender, signal) =>
            {
                DisplayCurrentReadCommand(signal);
                var data=signalDecoder.Decode(signal);
                Console.WriteLine($"Protocol: {data.Protocol} Address: {data.AddressNumber} Command: {data.CommandNumber} from Payload: {data.Payload}");
            };
            listener.Start();
            while (true)
            {
                Thread.Sleep(1000);
            }
        }

        private static void DisplayCurrentReadCommand(RmtCommand[] response)
        {
            Console.WriteLine($"Length:{response.Length.ToString()}");
            StringBuilder sb = new StringBuilder();
            foreach (var rmtCommand in response)
            {
                sb.Append("new RmtCommand(");
                sb.Append(rmtCommand.Duration0);
                sb.Append(",");
                sb.Append(rmtCommand.Level0.ToString().ToLower());
                sb.Append(",");
                sb.Append(rmtCommand.Duration1);
                sb.Append(",");
                sb.Append(rmtCommand.Level1.ToString().ToLower());
                sb.Append("),");
                sb.Append("\r\n");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}

