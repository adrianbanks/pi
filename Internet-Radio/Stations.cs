using System;
using System.Collections.Generic;

namespace Scratch
{
    public class Stations
    {
        private readonly Dictionary<ConsoleKey, Station> stations;

        public Stations()
        {
            stations = new Dictionary<ConsoleKey, Station>();
            stations.Add(ConsoleKey.D1, new Station("BBC Radio 1", "http://bbc.co.uk/radio/listen/live/r1.asx"));
            stations.Add(ConsoleKey.D2, new Station("BBC Radio 1xtra", "http://bbc.co.uk/radio/listen/live/r1x.asx"));
            stations.Add(ConsoleKey.D3, new Station("BBC Radio 2", "http://bbc.co.uk/radio/listen/live/r2.asx"));
            stations.Add(ConsoleKey.D4, new Station("BBC Radio 3", "http://bbc.co.uk/radio/listen/live/r3.asx"));
            stations.Add(ConsoleKey.D5, new Station("BBC Radio 4", "http://bbc.co.uk/radio/listen/live/r4.asx"));
            stations.Add(ConsoleKey.D6, new Station("BBC Radio 4 Extra", "http://www.bbc.co.uk/radio/listen/live/r4x.asx"));
            stations.Add(ConsoleKey.D7, new Station("BBC Radio 5 Live", "http://bbc.co.uk/radio/listen/live/r5l.asx"));
            stations.Add(ConsoleKey.D8, new Station("BBC Radio 5 Live Sports Extra", "http://bbc.co.uk/radio/listen/live/r5lsp.asx"));
            stations.Add(ConsoleKey.D9, new Station("BBC Radio 6", "http://bbc.co.uk/radio/listen/live/r6.asx"));
        }

        public void OutputStationList()
        {
            foreach (var kvp in stations)
            {
                Console.WriteLine("{0}. {1}", ((int) kvp.Key) - 48, kvp.Value.Name);
            }

            Console.WriteLine();
        }

        public Station GetStation(ConsoleKey key)
        {
            return stations[key];
        }
    }
}