using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonGoDesktop.API.Client.Services
{
	/// <summary>
	/// Contract for all objects in the world.
	/// </summary>
	public interface IWorldObject
	{
		//We don't use the interface to prevent boxing
		//In Unity3D boxing would be bad
		/// <summary>
		/// Real-world position of the <see cref="IWorldObject"/>.
		/// </summary>
		RealWorldPosition Position { get; }
	}
}
