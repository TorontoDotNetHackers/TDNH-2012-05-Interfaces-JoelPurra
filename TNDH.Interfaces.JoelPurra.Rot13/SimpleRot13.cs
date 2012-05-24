namespace TNDH.Interfaces.JoelPurra.Rot13
{
	using System;
	using TDNH;

	public class SimpleRot13 : IInformation
	{
		public SimpleRot13 ()
		{
		}

		#region IInformation implementation
		public string Transform (string incoming)
		{
			return incoming.Encode();
		}
		#endregion
	}
}
