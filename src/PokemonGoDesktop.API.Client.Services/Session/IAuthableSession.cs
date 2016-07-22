using PokemonGoDesktop.API.Common;
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
		/// Represents the current <see cref="AuthToken"/>.
		/// </summary>
		AuthToken Token { get; }
	}
}
