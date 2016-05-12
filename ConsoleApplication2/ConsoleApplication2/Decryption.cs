using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Decryption : CaesarAlgorithm
    {
        private string _message;
        
        public Decryption(string message)
        {
            this._message = message;
        }

        public override StringBuilder GetMessage(int key)
        {
            StringBuilder decryptionMessage = "";

            //foreach (char buchstabe in _message)
            //{
            //    string tempString = buchstabe.ToString();
            //    temp.TryGetValue(tempString, out tempVal);
            //    int encryptKey = tempVal + 23;
            //    if (encryptKey > temp.Count - 1)
            //    {
            //        encryptKey = encryptKey - temp.Count;
            //    }
            //    string encryptCharacter = "";
            //    tempDict2.TryGetValue(encryptKey, out encryptCharacter);

            //    verschluesselt.Append(encryptCharacter);
            //}

        }
    }
}
