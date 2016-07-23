using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonGoDesktop.API.Proto
{
	/// <summary>
	/// Contract for encounterable objects.
	/// </summary>
	public interface IEncounterable
	{
		/// <summary>
		/// 64bit encounter ID for the object.
		/// </summary>
		ulong EncounterId { get; }
	}
}
