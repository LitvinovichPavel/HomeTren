using System;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace JsonMetanit._2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMusic myCollection = new MyMusic();

            myCollection.Tracks = new Track[3];

            myCollection.Tracks[0] = new Track()
            {
                Artist = "Artist1",
                Album = "Album1",
                Title = "Title1",
                Year = "2001"
            };
            myCollection.Tracks[1] = new Track()
            {
                Artist = "Artist2",
                Album = "Album2",
                Title = "Title2",
                Year = "2002"
            };
            myCollection.Tracks[2] = new Track()
            {
                Artist = "Artist3",
                Album = "Album3",
                Title = "Title3",
                Year = "2003"
            };

            string serialized = JsonConvert.SerializeObject(myCollection);
            //Console.WriteLine($"SERIALIZE--> {serialized}");

            string json = serialized;
            MyMusic newMusic = JsonConvert.DeserializeObject<MyMusic>(json);

            foreach (var track in newMusic.Tracks)
            {
                Console.WriteLine($"ВСЕГО ДОБАВЛЕНО: {newMusic.Tracks.Length} {track.Artist} {track.Album} {track.Title} {track.Year}");
            }

            Console.WriteLine();
        }
    }
    class MyMusic
    {
        public Track[] Tracks { get; set; }
    }

    class Track
    {
        public string Artist { get; set; }
        public string Album { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }

    }
}
