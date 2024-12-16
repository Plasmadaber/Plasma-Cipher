using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;

namespace PlasmaCipher
{ 

	public class Encryption
	{
		private string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890!@#$%^&*()_+-=[]\\{}:;\"/.,<>|`'~? èéêëěẽēėęàáâäǎæãåāòóôöǒœøõōìíîïǐĩīıįùúûüǔũūűůÈÉÊËĚẼĒĖĘÀÁÂÄǍÆÃÅĀÒÓÔÖǑŒØÕŌÌÍÎÏǏĨĪİĮÙÚÛÜǓŨŪŰŮýŷÿÝŶŸ";
		private int _key;

		public Encryption(int key)
		{
			this._key = key;
		}

		public string EncryptMessage(string message)
		{
			List<char> letters = message.ToList();
			string newMess = "";
			foreach (char letter in letters)
			{
				newMess += EncryptChar(letter);
			}
			return newMess;
		}

		private char EncryptChar(char letter)
		{
            int newIndex = chars.IndexOf(letter) ^ _key;
			Console.WriteLine(letter);
            return chars[newIndex];
        }

	}

	public class Decryption
	{
        private string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890!@#$%^&*()_+-=[]\\{}:;\"/.,<>|`'~? èéêëěẽēėęàáâäǎæãåāòóôöǒœøõōìíîïǐĩīıįùúûüǔũūűůÈÉÊËĚẼĒĖĘÀÁÂÄǍÆÃÅĀÒÓÔÖǑŒØÕŌÌÍÎÏǏĨĪİĮÙÚÛÜǓŨŪŰŮýŷÿÝŶŸ";
		private int _key;
        public Decryption(int key)
		{
			this._key = key;
		}

		public string DecryptMessage(string message)
		{
            List<char> letters = message.ToList();
            string oldMess = "";
            foreach (char letter in letters)
            {
                oldMess += DecryptChar(letter);
            }
            return oldMess;
        }

		private char DecryptChar(char letter)
		{
            int oldIndex = chars.IndexOf(letter) ^ _key;
            return chars[oldIndex];
        }
	}
}

