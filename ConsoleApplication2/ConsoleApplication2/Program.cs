using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string klartext = "UX LNKX MH WKBGD RHNK HOTEMBGX";
            Dictionary<string, int> temp = new Dictionary<string, int>();
            Dictionary<int, string> tempDict2 = new Dictionary<int, string>();
            temp.Add("A", 0);
            temp.Add("B", 1);
            temp.Add("C", 2);
            temp.Add("D", 3);
            temp.Add("E", 4);
            temp.Add("F", 5);
            temp.Add("G", 6);
            temp.Add("H", 7);
            temp.Add("I", 8);
            temp.Add("J", 9);
            temp.Add("K", 10);
            temp.Add("L", 11);
            temp.Add("M", 12);
            temp.Add("N", 13);
            temp.Add("O", 14);
            temp.Add("P", 15);
            temp.Add("Q", 16);
            temp.Add("R", 17);
            temp.Add("S", 18);
            temp.Add("T", 19);
            temp.Add("U", 20);
            temp.Add("V", 21);
            temp.Add("W", 22);
            temp.Add("X", 23);
            temp.Add("Y", 24);
            temp.Add("Z", 25);

            foreach (KeyValuePair<string, int> item in temp)
            {
                tempDict2.Add(item.Value, item.Key);
            }

            char[] buchstaben = klartext.ToCharArray();

            StringBuilder verschluesselt = new StringBuilder();

            int tempVal = 0;

            foreach (char buchstabe in buchstaben)
            {
                string tempString = buchstabe.ToString();
                temp.TryGetValue(tempString, out tempVal);
                int encryptKey = tempVal + 7;
                if (encryptKey > temp.Count - 1)
                {
                    encryptKey -= temp.Count;
                }
                string encryptCharacter = "";
                tempDict2.TryGetValue(encryptKey, out encryptCharacter);
                encryptCharacter = tempString == " " ? " " : encryptCharacter;
                verschluesselt.Append(encryptCharacter);
            }

            Console.WriteLine("EncryptMessage: " + verschluesselt.ToString());
            Console.ReadLine();
        }
    }
}
