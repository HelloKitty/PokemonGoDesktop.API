using Networking.Envelopes;
using Networking.Requests;
using NUnit.Framework;
using PokemonGoDesktop.API.Common;
using PokemonGoDesktop.API.Proto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonGoDesktop.API.Proto.Services.Tests
{
	[TestFixture]
	public static class RequestEnvelopeExtensionsTests
	{
		[Test]
		public static void Test_Envelope_Extensions_Throw_On_Null_Envelope()
		{
			//arrange
			RequestEnvelope envelope = null;

			//assert
			Assert.Throws<ArgumentNullException>(() => envelope.WithAltitude(5));
			Assert.Throws<ArgumentNullException>(() => envelope.WithLatitude(5));
			Assert.Throws<ArgumentNullException>(() => envelope.WithLongitude(5));
			Assert.Throws<ArgumentNullException>(() => envelope.WithAuthTicket(new AuthTicket()));
			Assert.Throws<ArgumentNullException>(() => envelope.WithMessage(new Request()));
			Assert.Throws<ArgumentNullException>(() => envelope.WithRequestID());
			Assert.Throws<ArgumentNullException>(() => envelope.WithAuthenticationMessage(AuthType.Google, ""));
		}

		[Test]
		[TestCase(0)]
		[TestCase(double.MaxValue)]
		[TestCase(double.MinValue)]
		[TestCase(double.Epsilon)]
		[TestCase(-5)]
		public static void Test_Envelope_WithAltitude(double value)
		{
			//arrange
			RequestEnvelope envelope = new RequestEnvelope();

			//act
			envelope.WithAltitude(value);

			//assert
			Assert.AreEqual(value, envelope.Altitude);
		}

		[Test]
		[TestCase(0)]
		[TestCase(double.MaxValue)]
		[TestCase(double.MinValue)]
		[TestCase(double.Epsilon)]
		[TestCase(-5)]
		public static void Test_Envelope_WithLongitude(double value)
		{
			//arrange
			RequestEnvelope envelope = new RequestEnvelope();

			//act
			envelope.WithLongitude(value);

			//assert
			Assert.AreEqual(value, envelope.Longitude);
		}

		[Test]
		[TestCase(0)]
		[TestCase(double.MaxValue)]
		[TestCase(double.MinValue)]
		[TestCase(double.Epsilon)]
		[TestCase(-5)]
		public static void Test_Envelope_WithLatitude(double value)
		{
			//arrange
			RequestEnvelope envelope = new RequestEnvelope();

			//act
			envelope.WithLatitude(value);

			//assert
			Assert.AreEqual(value, envelope.Latitude);
		}

		[Test]
		public static void Test_Envelope_WithAuthTicket()
		{
			//arrange
			RequestEnvelope envelope = new RequestEnvelope();
			AuthTicket ticket = new AuthTicket();

			//act
			envelope.WithAuthTicket(ticket);

			//assert
			Assert.NotNull(envelope.AuthTicket);
			Assert.AreEqual(ticket, envelope.AuthTicket);
		}

		[Test]
		public static void Test_Envelope_WithAuthMessage()
		{
			//arrange
			RequestEnvelope envelope = new RequestEnvelope();

			//act
			envelope.WithAuthenticationMessage(AuthType.PTC, "test");

			//assert
			Assert.AreEqual(AuthType.PTC.ToProtocolString(), envelope.AuthInfo.Provider);
			Assert.AreEqual("test", envelope.AuthInfo.Token);
		}

		[Test]
		public static void Test_Envelope_WithMessage()
		{
			//arrange
			RequestEnvelope envelope = new RequestEnvelope();
			Request r = new Request();

			//act
			envelope.WithMessage(r);

			//assert
			Assert.IsTrue(envelope.Requests.Contains(r));
		}

		[Test]
		public static void Test_Envelope_WithMessages()
		{
			//arrange
			RequestEnvelope envelope = new RequestEnvelope();
			Request r = new Request();
			Request r2 = new Request();
			Request r3 = new Request();
			Request r4 = new Request();

			List<Request> requests = new List<Request>()
			{ r, r2, r3, r4 };

			requests.ForEach((req) => envelope.WithMessage(req));

			//act
			envelope.WithMessage(r);

			//assert
			foreach(var request in requests)
				Assert.IsTrue(envelope.Requests.Contains(request));
		}
	}
}
