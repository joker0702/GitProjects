using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpDX.XAudio2;
using SharpDX;

namespace XAudio2SharpDX
{
    class Program
    {
        static void Main(string[] args)
        {
            XAudio2 audioDevice = new XAudio2();
            Console.WriteLine("Device count: " + audioDevice.DeviceCount);
            for (int indexOfDevice = 0; indexOfDevice < audioDevice.DeviceCount; indexOfDevice++)
            {
                DeviceDetails deviceDetails = audioDevice.GetDeviceDetails(indexOfDevice);
                Console.WriteLine("DeviceID: " + deviceDetails.DeviceID);
                Console.WriteLine("Device Name: " + deviceDetails.DisplayName);
                Console.WriteLine("Output format:" + deviceDetails.OutputFormat);
                Console.WriteLine("Role: " + deviceDetails.Role);
                Console.WriteLine();
            }

            MasteringVoice masteringVoice = new MasteringVoice(audioDevice);
            Console.WriteLine("Volume: " + masteringVoice.Volume);
            Console.ReadKey();
        }
    }
}
