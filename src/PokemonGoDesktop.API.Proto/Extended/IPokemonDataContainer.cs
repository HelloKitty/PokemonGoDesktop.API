using PokemonGoDesktop.API.Proto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonGoDesktop.API.Proto
{
	/// <summary>
	/// Contract for types that are identifiable as Pokemon
	/// </summary>
	public interface IPokemonIdentitfiable
	{
		/// <summary>
		/// ID of the Pokemon.
		/// </summary>
		PokemonId PokemonId { get; }
	}
}
