using PokemonGoDesktop.API.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonGoDesktop.API.Client.Services
{
	/// <summary>
	/// Represents an authentication token that represents abstracted data
	/// about an auth response.
	/// </summary>
	public class AuthToken : IAuthToken
	{
		/// <summary>
		/// The type of the authentication.
		/// </summary>
		public AuthType TokenType { get; }

		/// <summary>
		/// Indicates if the auth token is valid.
		/// </summary>
		public bool isValid { get; }

		/// <summary>
		/// String token ID issued by the authentication
		/// </summary>
		public string TokenID { get; }

		public AuthToken(AuthType authType, bool valid, string tokenID)
		{
			TokenType = authType;
			isValid = valid;
			TokenID = tokenID;
		}
	}
}
