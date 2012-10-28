using System;
using System.Diagnostics;

namespace Scratch
{
    public sealed class Radio
    {
        private readonly Stations stations = new Stations();

        public void Run()
        {
            ConsoleKeyInfo key;

            do
            {
                Console.Clear();
                stations.OutputStationList();
                key = Console.ReadKey(true);
            }
            while (key.Key < ConsoleKey.D1 || key.Key > ConsoleKey.D9);

            var pId = PlayRadio(key.Key);

            do
            {
                Console.Clear();
                Console.WriteLine("Press s to stop");
            }
            while (Console.ReadKey(true).Key != ConsoleKey.S);

            var process = new Process {StartInfo = new ProcessStartInfo("kill") {Arguments = "-9 " + pId}};
            process.Start();
        }

        private int PlayRadio(ConsoleKey key)
        {
            var station = stations.GetStation(key);
            Console.WriteLine("Playing " + station.Name);

            var startInfo = new ProcessStartInfo
                {
                            FileName = "mplayer", 
                            Arguments = "-slave -msgcolor -quiet -playlist " + station.Url,
                            RedirectStandardOutput = false,
                            UseShellExecute = false
                };
            
            Process process = new Process {StartInfo = startInfo};
            process.Start();
            return process.Id;
        }
    }
}
