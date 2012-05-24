namespace TNDH.Interfaces.JoelPurra.Rot13
{
	using System;
	using System.Linq;

	public static class LookupRot13
	{
		public const string From = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
		public const string To = "NOPQRSTUVWXYZABCDEFGHIJKLMnopqrstuvwxyzabcdefghijklm";
		
		public static string Encode (this string input)
		{
			if (input == null) {
				return null;
			}
			
			return new string(input.Select(Encode).ToArray());
		}
		
		public static char Encode (this char input)
		{
			if (From.Contains (input)) {
				var index = From.IndexOf (input);
				
				return To[index];
			}
			
			return input;
		}
	}
}

