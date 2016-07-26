using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonGoDesktop.API.Proto
{
	public sealed partial class WildPokemon : IPokemonIdentitfiable
	{
		public PokemonId PokemonId
		{
			get
			{
				return this.PokemonData.PokemonId;
			}
		}
	}

	public sealed partial class NearbyPokemon : IPokemonIdentitfiable
	{

	}

	public sealed partial class MapPokemon : IPokemonIdentitfiable //Ferox' CatchablePokemon
	{

	}
}
