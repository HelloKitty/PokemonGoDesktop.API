using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGoDesktop.API.Proto
{
	public interface ICodeGenerator
	{
		/// <summary>
		/// Generatesa a string of code that has been setup.
		/// </summary>
		/// <returns>String that represents the .cs file.</returns>
		string Generate();
	}
}
