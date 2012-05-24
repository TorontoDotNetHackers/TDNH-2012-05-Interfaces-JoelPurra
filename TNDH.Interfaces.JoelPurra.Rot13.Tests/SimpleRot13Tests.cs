namespace TNDH.Interfaces.JoelPurra.Rot13.Tests
{
	using System;
	using NUnit.Framework;
	using TDNH;
	using TNDH.Interfaces.JoelPurra.Rot13;

	[TestFixture]
	public class SimpleRot13Tests
	{
		[Test]
		public void Null_in_null_out ()
		{
			IInformation information = new SimpleRot13();
			
			string input = null;
			string output = information.Transform(input);
			string expected = null;
			
			Assert.That(expected, Is.EqualTo(output));
		}
	}
}
