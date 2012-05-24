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
		public void Null_null ()
		{
			IInformation information = new SimpleRot13();
			
			string input = null;
			string output = information.Transform(input);
			string expected = null;
			
			Assert.That(expected, Is.EqualTo(output));
		}
		
		[Test]
		public void ABC_NOP ()
		{
			IInformation information = new SimpleRot13();
			
			string input = "ABC";
			string output = information.Transform(input);
			string expected = "NOP";
			
			Assert.That(expected, Is.EqualTo(output));
		}
		
		[Test]
		public void abc_nop ()
		{
			IInformation information = new SimpleRot13();
			
			string input = "abc";
			string output = information.Transform(input);
			string expected = "nop";
			
			Assert.That(expected, Is.EqualTo(output));
		}
	}
}
