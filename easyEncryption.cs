using System;

namespace encryption {
	class encryptedString {
		public string encryptedValue = "";
		public void encrypt(string stringToEncrypt, string key) {
			int keyMultiplier = 1;
			string output = "";
			foreach (char currentChar in key) {
				keyMultiplier = keyMultiplier * ((int)currentChar % 3);
			}
			foreach (char currentChar in stringToEncrypt) {
				int currentCharAsInt = (int)currentChar;
				int extra255s;
				string extra255sAsString;
				currentCharAsInt = currentCharAsInt * keyMultiplier;
				extra255s = (currentCharAsInt - (currentCharAsInt % 255)) / 255;
				currentCharAsInt = currentCharAsInt % 255;
				extra255sAsString = extra255s.ToString();
				if (extra255sAsString.Length == 1) {
					extra255sAsString = "0" + extra255sAsString;
				}
				output += (char)currentCharAsInt + extra255sAsString;
			}
			encryptedValue = output;
		}
		
		public void decrypt(string stringToDecrypt, string key) {
			int keyMultiplier = 1;
			string output = "";
			foreach (char currentChar in key) {
				keyMultiplier = keyMultiplier * ((int)currentChar % 3);
			}
			for (int i = 0; i < stringToDecrypt.Length; i = i + 3) {
				int charAsInt = (int)stringToDecrypt[i];
				int extra255s = Int32.Parse(stringToDecrypt[i + 1].ToString() + stringToDecrypt[i + 2].ToString());
				charAsInt += (255 * extra255s);
				charAsInt = charAsInt / keyMultiplier;
				output += (char)charAsInt;
			}
			encryptedValue = output;
		}
	}
}
