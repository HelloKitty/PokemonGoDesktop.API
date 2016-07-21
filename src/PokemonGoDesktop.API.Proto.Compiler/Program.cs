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
			foreach(string s in Directory.GetFiles(Directory.GetCurrentDirectory(), "*.proto", SearchOption.AllDirectories))
			{
				Console.WriteLine($"Reading .proto at Path: {s}");

				//This could be task-based and threaded but having 200 protocs running can suck.
				using (var p = new System.Diagnostics.Process())
				{
					//protoc --proto_path=src --csharp_out=build/gen src/*.proto
					p.StartInfo.FileName = Path.Combine(Directory.GetCurrentDirectory(), @"protoc.exe");
					p.StartInfo.Arguments = $"--proto_path={Path.GetDirectoryName(s)} --csharp_out={Path.GetDirectoryName(s)} {s}";
					p.StartInfo.RedirectStandardOutput = false;
					p.StartInfo.UseShellExecute = false;
					p.StartInfo.CreateNoWindow = true;
					p.Start();

					p.WaitForExit();
				}
			}

			Console.ReadKey();
		}
	}
}
