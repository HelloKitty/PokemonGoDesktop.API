using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonGoDesktop.API.Client.Services
{
	public interface IUserAuthenticationService
	{
		/// <summary>
		/// Attempts to authenticate and produces a result token.
		/// </summary>
		/// <returns>A result token from the autentication attempt.</returns>
		AuthToken TryAuthenticate();
	}
}
