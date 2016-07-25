using PokemonGoDesktop.API.Common;
using PokemonGoDesktop.API.Proto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonGoDesktop.API.Client.Services
{
	/// <summary>
	/// Authenticatable session contract.
	/// </summary>
	public interface IAuthableSession : ISession
	{
		/// <summary>
		/// Represents the current <see cref="IAuthToken"/>.
		/// </summary>
		IAuthToken Token { get; }

		/// <summary>
		/// Represents the current <see cref="AuthTicket"/>
		/// (See .proto def)
		/// </summary>
		AuthTicket AuthTicket { get; }
	}
}
