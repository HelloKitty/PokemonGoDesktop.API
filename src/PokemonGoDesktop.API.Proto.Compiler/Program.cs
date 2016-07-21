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

			foreach(string s in Directory.GetFiles(Directory.GetCurrentDirectory(), "*.proto", SearchOption.AllDirectories))
			{
				Console.WriteLine($"Reading .proto at Path: {GetRelativePath(s, Directory.GetCurrentDirectory())}");

				//We have to provide protoc with the relative, not absolute, path or it won't know what to do
				builder.Append($"{GetRelativePath(s, Directory.GetCurrentDirectory())} ");
			}

			//This could be task-based and threaded but having 200 protocs running can suck.
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

			Console.ReadKey();
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
