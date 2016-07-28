using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonGoDesktop.API.Proto
{
	/// <summary>
	/// Contracts for all objects that appear in the world.
	/// </summary>
	public interface IMapCellObject
	{
		/// <summary>
		/// Latitude of the object.
		/// </summary>
		double Latitude { get; }

		/// <summary>
		/// Longitude of the object.
		/// </summary>
		double Longitude { get; }
	}
}
