using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonGoDesktop.API.Client.Services
{
	/// <summary>
	/// Contract for Trainers.
	/// </summary>
	public interface ITrainer : IWorldObject
	{
		/// <summary>
		/// Indicates the level of the <see cref="ITrainer"/> object.
		/// </summary>
		int Level { get; }

		/// <summary>
		/// Indicates the name of the trainer object.
		/// </summary>
		string TrainerName { get; }
	}
}
