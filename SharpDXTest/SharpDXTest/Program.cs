using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpDX.XInput;

namespace SharpDXTest
{
    class Program
    {
        static Vibration vibration;

        static void Main(string[] args)
        {
            Controller xbox = new Controller(UserIndex.One);
            Console.WriteLine("Controller connected: " + xbox.IsConnected);
            BatteryInformation battery = xbox.GetBatteryInformation(BatteryDeviceType.Gamepad);
            Console.WriteLine("Battery level: " + battery.BatteryLevel);

            bool isRunning = true;
            

            while (isRunning)
            {
                Console.Clear();
                State state = xbox.GetState();

                switch (state.Gamepad.Buttons)
                {
                    case GamepadButtonFlags.Start:
                        isRunning = false;
                        break;
                    default:
                        break;
                }

                Console.Write("Key pressed: " + state.Gamepad.Buttons + "\n");
                Console.Write("RightThumbX stick: " + state.Gamepad.RightThumbX + "\n");
                Console.Write("RightThumbY stick: " + state.Gamepad.RightThumbY + "\n");
                Console.Write("LeftThumbX stick: " + state.Gamepad.LeftThumbX + "\n");
                Console.Write("LeftThumbY stick: " + state.Gamepad.LeftThumbY + "\n");
                Console.Write("LeftTrigger: " + state.Gamepad.LeftTrigger + "\n");
                Console.Write("RightTrigger: " + state.Gamepad.RightTrigger + "\n");

                int vibrationLeftMotorSpeed = 0;
                

                if (state.Gamepad.LeftThumbX > -1)
                    vibrationLeftMotorSpeed = state.Gamepad.LeftThumbX;

                vibration.LeftMotorSpeed = (ushort)vibrationLeftMotorSpeed;
                xbox.SetVibration(vibration);
                System.Threading.Thread.Sleep(100);
            }
        }
    }
}
