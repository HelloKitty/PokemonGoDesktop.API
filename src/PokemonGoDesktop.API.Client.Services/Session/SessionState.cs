using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonGoDesktop.API.Client.Services
{
	/// <summary>
	/// Indicates the current session state.
	/// </summary>
	[Flags]
	public enum SessionState
	{
		/// <summary>
		/// Nothing.
		/// </summary>
		Default = 0,
		
		/// <summary>
		/// Indicates if the session has been authenticated.
		/// </summary>
		Authenticated = 1 << 1,

		/// <summary>
		/// Indicates if we have a valid AuthTicket.
		/// </summary>
		HasValidAuthTicket = 1 << 2
	}
}
