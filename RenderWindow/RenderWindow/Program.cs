using System;
using System.Collections.Generic;
using System.Text;
using SharpDX.Windows;
using SharpDX.DirectInput;

namespace RenderWindow
{
    class Program
    {
        private static RenderForm form;

        static void Main(string[] args)
        {
            using (form = new RenderForm("My first rendered Window"))
            {
                RenderLoop.Run(form, RenderCallback);
            }
        }

        private static void RenderCallback()
        {
            Console.Clear();
            DirectInput directInput = new DirectInput();
            Keyboard keyboard = new Keyboard(directInput);
            keyboard.SetCooperativeLevel(form, CooperativeLevel.Background | CooperativeLevel.NonExclusive);
            keyboard.Acquire();
            KeyboardState keyState = keyboard.GetCurrentState();

            if (keyState.IsPressed(Key.Escape))
            {
                form.Close();
                form.Dispose();
            }
        }
    }
}
