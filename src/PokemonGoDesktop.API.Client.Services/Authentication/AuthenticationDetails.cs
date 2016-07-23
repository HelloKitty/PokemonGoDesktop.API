using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonGoDesktop.API.Client.Services
{
	/// <summary>
	/// Simple POCO that contains the user provided login details.
	/// </summary>
	public class AuthenticationDetails
	{
		/// <summary>
		/// String to auth as.
		/// </summary>
		public string LoginString { get; }

		/// <summary>
		/// Authentication password.
		/// </summary>
		public string Password { get; }

		public AuthenticationDetails(string loginString, string password)
		{
			LoginString = loginString;
			Password = password;
		}
	}
}
