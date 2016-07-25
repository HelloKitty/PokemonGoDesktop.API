using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonGoDesktop.API.Client.Services
{
	/// <summary>
	/// Immutable value-type for a real world position.
	/// </summary>
	public struct RealWorldPosition : IPosition
	{
		/// <summary>
		/// Latitude of the position.
		/// </summary>
		public double Latitude { get; }

		/// <summary>
		/// Longitude of the position.
		/// </summary>
		public double Longitude { get; }

		/// <summary>
		/// Longitude of the position.
		/// </summary>
		public double Altitude { get; }
	}
}
