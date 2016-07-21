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
	public class IResponseMarkersGenerator : MessageMarkersGenerator
	{
		/// <summary>
		/// Creates a new response market code generator with the provided
		/// response proto/file names.
		/// </summary>
		/// <param name="responseFileNames"></param>
		public IResponseMarkersGenerator(IEnumerable<string> responseFileNames)
			: base(responseFileNames)
		{

		}

		protected override string markerInterfaceName { get { return "IResponseMessage"; } }

		protected override QualifiedNameSyntax networkMessageNamespace
		{
			get
			{
				return QualifiedName
					(
						SyntaxFactory.QualifiedName
						(
							SyntaxFactory.IdentifierName("Networking"),
							SyntaxFactory.IdentifierName("Responses")
						)
						.WithDotToken
						(
							SyntaxFactory.Token(SyntaxKind.DotToken)
						),
						IdentifierName
						(
							Identifier
							(
								TriviaList(),
								"Responses",
								TriviaList
								(
									LineFeed
								)
							)
						)
					)
					.WithDotToken
					(
						Token(SyntaxKind.DotToken)
					);
			}
		}
	}
}
