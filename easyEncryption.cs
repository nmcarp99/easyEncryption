using System;

namespace encryption {
	class encryptString {
		public string encrypt(string stringToEncrypt, string key) {
			int keyMultiplier = 0;
			string output = "";
			foreach (char currentChar in key) {
				keyMultiplier = keyMultiplier * ((int)currentChar % 3);
			}
			foreach (char currentChar in stringToEncrypt) {
				int currentCharAsInt = (int)currentChar;
				
				currentCharAsInt = currentCharAsInt * keyMultiplier;
				

class main {
	static void Main() {
		Console.WriteLine("Starting...");
	}
}
