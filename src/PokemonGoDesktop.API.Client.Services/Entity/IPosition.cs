using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonGoDesktop.API.Client.Services
{
	/// <summary>
	/// Contract for position.
	/// </summary>
	public interface IPosition
	{
		/// <summary>
		/// Latitude of the position.
		/// </summary>
		double Latitude { get; }

		/// <summary>
		/// Longitude of the position.
		/// </summary>
		double Longitude { get; }

		/// <summary>
		/// Longitude of the position.
		/// </summary>
		double Altitude { get; }
	}
}
