using PokemonGoDesktop.API.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonGoDesktop.API.Client.Services
{
	/// <summary>
	/// Base contract for AuthTokens
	/// Represents an authentication token that represents abstracted data
	/// about an auth response.
	/// </summary>
	public interface IAuthToken
	{
		/// <summary>
		/// The type of the authentication.
		/// </summary>
		AuthType TokenType { get; }

		/// <summary>
		/// Indicates if the auth token is valid.
		/// </summary>
		bool isValid { get; }

		/// <summary>
		/// String token ID issued by the authentication
		/// </summary>
		string TokenID { get; }
	}
}
