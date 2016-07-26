using Easyception;
using PokemonGoDesktop.API.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonGoDesktop.API.Proto
{
	/// <summary>
	/// Extension methods for the <see cref="RequestEnvelope"/> type.
	/// </summary>
	public static class RequestEnvelopeExtensions
	{
		/// <summary>
		/// Configures the <see cref="RequestEnvelope"/> with a <see cref="Request"/> message
		/// </summary>
		/// <param name="env">Request envelope instance.</param>
		/// <param name="message"></param>
		/// <returns>Reference to the provided and configured envelope.</returns>
		public static RequestEnvelope WithMessage(this RequestEnvelope env, Request message)
		{
			Throw<ArgumentNullException>.If.IsNull(env)?.Now(nameof(env), "The provided envelop cannot be null during fluent configuration.");
			Throw<ArgumentNullException>.If.IsNull(message)?.Now(nameof(message), $"The provided {nameof(Request)} is null and therefore invalid");

			env.Requests.Add(message);
			return env;
		}

		/// <summary>
		/// Configures the <see cref="RequestEnvelope"/> with a multiple<see cref="Request"/> message
		/// </summary>
		/// <param name="env">Request envelope instance.</param>
		/// <param name="messages"></param>
		/// <returns>Reference to the provided and configured envelope.</returns>
		public static RequestEnvelope WithMessage(this RequestEnvelope env, IEnumerable<Request> messages)
		{
			Throw<ArgumentNullException>.If.IsNull(env)?.Now(nameof(env), "The provided envelop cannot be null during fluent configuration.");
			Throw<ArgumentNullException>.If.IsNull(messages)?.Now(nameof(messages), $"The provided {nameof(Request)} is null and therefore invalid");

			if(messages.Count() > 0)
				env.Requests.Add(messages);

			return env;
		}

		/// <summary>
		/// Configures the <see cref="RequestEnvelope"/> with the specified <paramref name="altitude"/>.
		/// </summary>
		/// <param name="env">Request envelope instance.</param>
		/// <param name="altitude"></param>
		/// <returns>Reference to the provided and configured envelope.</returns>
		public static RequestEnvelope WithAltitude(this RequestEnvelope env, double altitude)
		{
			Throw<ArgumentNullException>.If.IsNull(env)?.Now(nameof(env), "The provided envelop cannot be null during fluent configuration.");

			env.Altitude = altitude;
			return env;
		}

		/// <summary>
		/// Configures the <see cref="RequestEnvelope"/> with the specified <paramref name="altitude"/>.
		/// </summary>
		/// <param name="env">Request envelope instance.</param>
		/// <param name="latitude"></param>
		/// <returns>Reference to the provided and configured envelope.</returns>
		public static RequestEnvelope WithLatitude(this RequestEnvelope env, double latitude)
		{
			Throw<ArgumentNullException>.If.IsNull(env)?.Now(nameof(env), "The provided envelop cannot be null during fluent configuration.");

			env.Latitude = latitude;
			return env;
		}

		/// <summary>
		/// Configures the <see cref="RequestEnvelope"/> with the specified <paramref name="altitude"/>.
		/// </summary>
		/// <param name="env">Request envelope instance.</param>
		/// <param name="longitude"></param>
		/// <returns>Reference to the provided and configured envelope.</returns>
		public static RequestEnvelope WithLongitude(this RequestEnvelope env, double longitude)
		{
			Throw<ArgumentNullException>.If.IsNull(env)?.Now(nameof(env), "The provided envelop cannot be null during fluent configuration.");

			env.Longitude = longitude;
			return env;
		}

		/// <summary>
		/// Configures the <see cref="RequestEnvelope"/> with the specified <paramref name="altitude"/>.
		/// </summary>
		/// <param name="env">Request envelope instance.</param>
		/// <param name="requestID"></param>
		/// <returns>Reference to the provided and configured envelope.</returns>
		public static RequestEnvelope WithRequestID(this RequestEnvelope env, ulong requestID)
		{
			Throw<ArgumentNullException>.If.IsNull(env)?.Now(nameof(env), "The provided envelop cannot be null during fluent configuration.");

			//Same thing as RPC ID from Rocket-API
			env.RequestId = requestID;
			return env;
		}

		/// <summary>
		/// Configures the <see cref="RequestEnvelope"/> with the specified <paramref name="altitude"/>.
		/// </summary>
		/// <param name="env">Request envelope instance.</param>
		/// <returns>Reference to the provided and configured envelope.</returns>
		public static RequestEnvelope WithRequestID(this RequestEnvelope env)
		{
			Throw<ArgumentNullException>.If.IsNull(env)?.Now(nameof(env), "The provided envelop cannot be null during fluent configuration.");

			env.RequestId = 1469378659230941192; //This is what Rocket-API uses for some reason https://github.com/FeroxRev/Pokemon-Go-Rocket-API/blob/bca2166d72aaa9799c64965cc4f94748231283eb/PokemonGo.RocketAPI/Helpers/RequestBuilder.cs
			return env;
		}

		/// <summary>
		/// Configures the <see cref="RequestEnvelope"/>'s authentication parameters.
		/// </summary>
		/// <param name="env">Request envelope instance.</param>
		public static void WithAuthenticationMessage(this RequestEnvelope env, AuthType authType, string authTokenContent)
		{
			Throw<ArgumentNullException>.If.IsNull(env)?.Now(nameof(env), "The provided envelop cannot be null during fluent configuration.");

			//We must create the AuthInfo first
			env.AuthInfo = new RequestEnvelope.Types.AuthInfo();

			env.AuthInfo.Provider = authType.ToProtocolString();

			//based on Rocket-API token building
			env.AuthInfo.Token = new RequestEnvelope.Types.AuthInfo.Types.JWT
			{
				//this is int32 unknown13  = 2; in Rocket-API's token. The seem to set it to 14 for some reason
				//https://github.com/FeroxRev/Pokemon-Go-Rocket-API/blob/master/PokemonGo.RocketAPI/Helpers/RequestBuilder.cs
				Unknown2 = 14,
				Contents = authTokenContent
			};

			//Things that the user can't really deal with, because the community doesn't know what they really are, are initialized below.
			env.StatusCode = 2; //Rocket-API sets it to 2:  https://github.com/FeroxRev/Pokemon-Go-Rocket-API/blob/bca2166d72aaa9799c64965cc4f94748231283eb/PokemonGo.RocketAPI/Helpers/RequestBuilder.cs
			env.Unknown12 = 989; //Required otherwise we receive incompatible protocol as indicated in Rocket-API: https://github.com/FeroxRev/Pokemon-Go-Rocket-API/blob/bca2166d72aaa9799c64965cc4f94748231283eb/PokemonGo.RocketAPI/Helpers/RequestBuilder.cs
		}

		/// <summary>
		/// Configures the <see cref="RequestEnvelope"/> 
		/// </summary>
		/// <param name="env">Request envelope instance.</param>
		public static void WithAuthTicket(this RequestEnvelope env, AuthTicket ticket)
		{
			Throw<ArgumentNullException>.If.IsNull(env)?.Now(nameof(env), "The provided envelop cannot be null during fluent configuration.");

			//This holds data from the server auth resposne that we use as a ticket for other messages
			env.AuthTicket = ticket;

			//Things that the user can't really deal with, because the community doesn't know what they really are, are initialized below.
			env.StatusCode = 2; //Rocket-API sets it to 2:  https://github.com/FeroxRev/Pokemon-Go-Rocket-API/blob/bca2166d72aaa9799c64965cc4f94748231283eb/PokemonGo.RocketAPI/Helpers/RequestBuilder.cs
			env.Unknown12 = 989; //Required otherwise we receive incompatible protocol as indicated in Rocket-API: https://github.com/FeroxRev/Pokemon-Go-Rocket-API/blob/bca2166d72aaa9799c64965cc4f94748231283eb/PokemonGo.RocketAPI/Helpers/RequestBuilder.cs
		}
	}
}
