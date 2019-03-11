
namespace OnlineRadionDatabase
{
    using OnlineRadionDatabase.Exceptions;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class ListOfSongs
    {
        private List<Song> playList;

        public ListOfSongs()
        {
            this.playList = new List<Song>();
        }

        public void Play()
        {
            var numberOfSongs = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfSongs; i++)
            {
                try
                {
                    var input = Console.ReadLine().Split(';',StringSplitOptions.RemoveEmptyEntries);

                    if(input.Length != 3)
                    {
                        throw new InvalidSongException();
                    }

                    var artistName = input[0];
                    var songName = input[1];
                    var length = input[2].Split(':', StringSplitOptions.RemoveEmptyEntries);

                    if(!int.TryParse(length[0], out int minutes) || !int.TryParse(length[1], out int seconds))
                    {
                        throw new InvalidSongLengthException();
                    }

                    var song = new Song(artistName, songName, minutes, seconds);
                    playList.Add(song);
                    Console.WriteLine("Song added.");
                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            var totalSeconds = playList.Sum(x => (x.Minutes * 60) + x.Seconds);
            var timeSpan = TimeSpan.FromSeconds(totalSeconds);
            Console.WriteLine($"Songs added: {playList.Count}");
            Console.WriteLine($"Playlist length: {timeSpan.Hours}h {timeSpan.Minutes}m {timeSpan.Seconds}s");
        }
    }
}
