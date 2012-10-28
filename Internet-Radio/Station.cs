namespace Scratch
{
    public class Station
    {
        public string Name{get;set;}
        public string Url{get;set;}

        public Station(string name, string url)
        {
            Name = name;
            Url = url;
        }
    }
}