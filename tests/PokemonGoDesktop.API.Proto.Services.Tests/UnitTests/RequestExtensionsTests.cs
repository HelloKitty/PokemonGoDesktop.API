using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonGoDesktop.API.Proto.Services.Tests
{
	[TestFixture]
	public class RequestExtensionsTests
	{
		[Test]
		public static void Test_Request_Packs_In_Non_Null_Envelope()
		{
			//arrange
			Request r = new Request();

			//assert
			Assert.NotNull(r.PackInEnvelope());
		}

		[Test]
		public static void Test_Request_Packs_Throws_Null_If_Request_Is_Null()
		{
			//arrange
			Request r = null;

			//assert
			ArgumentNullException ex = Assert.Throws<ArgumentNullException>(() => r.PackInEnvelope());

			//Check the exception contains the right parameter
			Assert.AreEqual("request", ex.ParamName);
		}
	}
}
