using Easyception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonGoDesktop.API.Proto.Services
{
	/// <summary>
	/// Extension methods for the <see cref="Request"/> type.
	/// </summary>
	public static class RequestExtensions
	{
		/// <summary>
		/// Packages the <see cref="Request"/> in an uninitialized envelope.
		/// </summary>
		/// <param name="request">The request message.</param>
		/// <returns></returns>
		public static RequestEnvelope PackInEnvelope(this Request request)
		{
			Throw<ArgumentNullException>.If.IsNull(request)?.Now(nameof(request), "The provided request cannot be null for envelope packing.");

			RequestEnvelope envelope = new RequestEnvelope();

			//TODO: Check if this is null
			envelope.Requests.Add(request);


			//Things that the user can't really deal with, because the community doesn't know what they really are, are initialized below.
			envelope.StatusCode = 2; //Rocket-API sets it to 2:  https://github.com/FeroxRev/Pokemon-Go-Rocket-API/blob/bca2166d72aaa9799c64965cc4f94748231283eb/PokemonGo.RocketAPI/Helpers/RequestBuilder.cs
			envelope.Unknown12 = 989; //Required otherwise we receive incompatible protocol as indicated in Rocket-API: https://github.com/FeroxRev/Pokemon-Go-Rocket-API/blob/bca2166d72aaa9799c64965cc4f94748231283eb/PokemonGo.RocketAPI/Helpers/RequestBuilder.cs

			//We reutnr the envelope for two reasons; One, because it was constructed but also
			//because we expect the user to fluently set the values.
			return envelope;
		}
	}
}
