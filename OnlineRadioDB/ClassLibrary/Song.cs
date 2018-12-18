using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Song
    {
        private string songName;
        private string artistName;
        private TimeSpan songLength;

        public Song(string songName, string artistName)
        {
            SongName = songName;
            ArtistName = artistName;
        }

        public string SongName
        {
            get => songName;
            set
            {
                try
                {
                    if (value.Length < 30 && value.Length > 3)
                    {
                        songName = value;
                    }
                    else
                    {
                        throw new Exception("Invalid Songname. Try one with 3 to 30 characters!");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
        }

        public string ArtistName
        {
            get => artistName;
            set
            {
                try
                {
                    if (value.Length > 2 && value.Length < 21)
                    {
                        artistName = value;
                    }
                    else
                    {
                        throw new Exception("Invalid Artistname. Try one with 3 to 20 characters!");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
        }

        public TimeSpan SongLength
        {
            get => songLength;
            set
            {

            }
        }
    }
}
