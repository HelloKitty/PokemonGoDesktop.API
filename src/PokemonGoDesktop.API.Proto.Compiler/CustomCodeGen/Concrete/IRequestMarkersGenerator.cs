using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Formatting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;


namespace PokemonGoDesktop.API.Proto.Compiler
{
	public class IRequestMarkersGenerator : MessageMarkersGenerator
	{
		/// <summary>
		/// Creates a new request market code generator with the provided
		/// request proto/file names.
		/// </summary>
		/// <param name="requestFileNames"></param>
		public IRequestMarkersGenerator(IEnumerable<string> requestFileNames)
			: base(requestFileNames)
		{

		}

		protected override string markerInterfaceName { get { return "IRequestMessage"; } }
	}
}
