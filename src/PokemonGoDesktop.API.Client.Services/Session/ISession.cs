using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonGoDesktop.API.Client.Services
{
	public delegate void OnSessionStateChanged(SessionState state);

	/// <summary>
	/// Session for the PokemonGoDesktop client.
	/// </summary>
	public interface ISession
	{
		/// <summary>
		/// Indicates the current state of the session.
		/// </summary>
		SessionState CurrentSessionState { get; }

		/// <summary>
		/// Invoked when the <see cref="CurrentSessionState"/> has changed.
		/// </summary>
		event OnSessionStateChanged StatusChangedEvent;
	}
}
