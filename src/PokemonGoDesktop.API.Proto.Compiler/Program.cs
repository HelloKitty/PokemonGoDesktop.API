using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGoDesktop.API.Proto.Compiler
{
	public class Program
	{
		static void Main(string[] args)
		{
			//Grabs all the proto file names
			StringBuilder builder = new StringBuilder($"--csharp_out=Gen ");

			//Finds all the proto files in sub dirs.
			IEnumerable<string> filePaths = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.proto", SearchOption.AllDirectories);

			foreach (string s in filePaths)
			{
				Console.WriteLine($"Reading .proto at Path: {GetRelativePath(s, Directory.GetCurrentDirectory())}");

				//We have to provide protoc with the relative, not absolute, path or it won't know what to do
				builder.Append($"{GetRelativePath(s, Directory.GetCurrentDirectory())} ");
			}

			//create a process to call invoke protoc
			using (var p = new System.Diagnostics.Process())
			{
				//protoc --proto_path=src --csharp_out=build/gen src/*.proto
				p.StartInfo.FileName = Path.Combine(Directory.GetCurrentDirectory(), @"protoc.exe");
				p.StartInfo.Arguments = builder.ToString();
				p.StartInfo.RedirectStandardOutput = false;
				p.StartInfo.UseShellExecute = false;
				p.StartInfo.CreateNoWindow = false;
				p.Start();

				p.WaitForExit();
			}

			Console.WriteLine("Finished Generating classes from .proto with Protoc");

			GenerateRequestMarkers();
			GenerateResponseMarkers();

			Console.WriteLine("Generated extended classes for Proto.");

			Console.ReadKey();
		}

		private static void GenerateRequestMarkers()
		{
			IRequestMarkersGenerator requestMarketGenerator = null;

			try
			{
				//Make sure to pass in only the filenames and not the actual paths
				requestMarketGenerator = new IRequestMarkersGenerator(Directory.GetFiles(Path.Combine(Directory.GetCurrentDirectory(), @"Networking/Requests/Messages/")).Select(fp => Path.GetFileNameWithoutExtension(fp)));
			}
			catch (Exception e)
			{
				Console.WriteLine($"Error: {e.Message} StackTrace: {e.StackTrace}");
			}

			try
			{
				if (requestMarketGenerator != null)
					File.WriteAllText(@"Gen/RequestClassExtended.cs", requestMarketGenerator.Generate());
			}
			catch (Exception e)
			{
				Console.WriteLine($"Error: {e.Message} StackTrace: {e.StackTrace}");
			}
		}

		private static void GenerateResponseMarkers()
		{
			IResponseMarkersGenerator responseMarketGenerator = null;

			try
			{
				//Make sure to pass in only the filenames and not the actual paths
				responseMarketGenerator = new IResponseMarkersGenerator(Directory.GetFiles(Path.Combine(Directory.GetCurrentDirectory(), @"Networking/Responses/")).Select(fp => Path.GetFileNameWithoutExtension(fp)));
			}
			catch (Exception e)
			{
				Console.WriteLine($"Error: {e.Message} StackTrace: {e.StackTrace}");
			}

			try
			{
				if (responseMarketGenerator != null)
					File.WriteAllText(@"Gen/ResponseClassExtended.cs", responseMarketGenerator.Generate());
			}
			catch (Exception e)
			{
				Console.WriteLine($"Error: {e.Message} StackTrace: {e.StackTrace}");
			}
		}



		//From: http://stackoverflow.com/questions/703281/getting-path-relative-to-the-current-working-directory/703290#703290
		static string GetRelativePath(string filespec, string folder)
		{
			Uri pathUri = new Uri(filespec);
			// Folders must end in a slash
			if (!folder.EndsWith(Path.DirectorySeparatorChar.ToString()))
			{
				folder += Path.DirectorySeparatorChar;
			}
			Uri folderUri = new Uri(folder);
			return Uri.UnescapeDataString(folderUri.MakeRelativeUri(pathUri).ToString().Replace('/', Path.DirectorySeparatorChar));
		}
	}
}
