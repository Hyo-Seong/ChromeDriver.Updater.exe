using CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChromeDriver.Updater.exe
{
    public class CommandLineOptions
    {
        [Option(shortName: 'c', longName: "chromedriverpath", Required = true)]
        public string ChromeDriverPath { get; set; }
    }
}
