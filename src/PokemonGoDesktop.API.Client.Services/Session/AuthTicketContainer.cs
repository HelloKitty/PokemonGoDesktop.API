using PokemonGoDesktop.API.Proto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonGoDesktop.API.Client.Services
{
	/// <summary>
	/// Container for the <see cref="AuthTicket"/> and the API URL.
	/// </summary>
	public class AuthTicketContainer
	{
		/// <summary>
		/// The <see cref="AuthTicket"/> instance.
		/// </summary>
		public AuthTicket Ticket { get; }

		/// <summary>
		/// The API URL associated with the token.
		/// </summary>
		public string ApiUrl { get; }

		/// <summary>
		/// Creates a new container for the <see cref="AuthTicket"/> and a paired
		/// API url.
		/// </summary>
		/// <param name="ticket">Ticket to contain.</param>
		/// <param name="apiUrl">Valid API url that pairs with the <see cref="Ticket"/>.</param>
		public AuthTicketContainer(AuthTicket ticket, string apiUrl)
		{
			Ticket = ticket;
			ApiUrl = apiUrl;
		}
	}
}
