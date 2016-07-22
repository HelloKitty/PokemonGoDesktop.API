using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonGoDesktop.API.Common
{
	/// <summary>
	/// Extensions for the <see cref="AuthType"/> enum type.
	/// </summary>
	public static class AuthTypeExtensions
	{
		/// <summary>
		/// Converts the <see cref="AuthType"/> provided to the valid network
		/// protocol string.
		/// </summary>
		/// <param name="authType"></param>
		/// <returns></returns>
		public static string ToProtocolString(this AuthType authType)
		{
			switch (authType)
			{
				//We could do fancy Enum stuff or Reflection
				//to get these values but SPOILER ALERT... They could change
				//Based on Rocket-API protocol strings https://github.com/FeroxRev/Pokemon-Go-Rocket-API/blob/bca2166d72aaa9799c64965cc4f94748231283eb/PokemonGo.RocketAPI/Helpers/RequestBuilder.cs
				case AuthType.Google:
					return "google";
				case AuthType.PTC:
					return "ptc";
				default:
					return "unknown";
			}
		}
	}
}
