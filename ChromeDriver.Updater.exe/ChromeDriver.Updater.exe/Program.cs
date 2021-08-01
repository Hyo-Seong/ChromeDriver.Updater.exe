using ChromeDriverUpdater.Models;
using CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChromeDriver.Updater.exe
{
    class Program
    {
        static async Task<int> Main(string[] args)
        {
            return (int)Parser.Default.ParseArguments<CommandLineOptions>(args)
                .MapResult(
                    opts => new ChromeDriverUpdater.Updater().Update(opts.ChromeDriverPath),
                    errs => ExitCode.Fail
                );
        }
    }
}
