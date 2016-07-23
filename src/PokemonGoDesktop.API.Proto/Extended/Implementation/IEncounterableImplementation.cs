using PokemonGoDesktop.API.Proto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace PokemonGoDesktop.API.Proto
{
	//Create the public sealed partial classes they must have the same namespace as the target proto classes
	//Implement the interfaces you want them to share and have.
	public sealed partial class WildPokemon : IEncounterable
	{

	}

	public sealed partial class NearbyPokemon : IEncounterable
	{

	}

	public sealed partial class MapPokemon : IEncounterable //Ferox' CatchablePokemon
	{

	}

	//You can add interfaces to data types AND response/request types too
	//Though most usually won't share data. EncounterId happens to be so prevelant that you'll see it in many classes.
	public sealed partial class GetIncensePokemonResponse : IEncounterable
	{

	}
}