using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class MusicCD : Product
    {
        public List<Track> Tracks { get; } = new List<Track>(); 
        public string Artist { get; set; }
        public string Label{ get; set; }
        public short Released { get; set; }

        public MusicCD()
        {

        }
        public MusicCD(string artist, string title
            , decimal price, string label, short released, string imageurl) 
            : base(title,price,imageurl)
        {
            
            Artist = artist;
            Label = label;
            Released = released;

        }
        //In order to use the Tracks 
        //List you must first initialize it as a new List object of the type string:
       // public List<string> Track { get; } = new List<string>();

        public void AddTrack(Track trackName)
        {
            Tracks.Add(trackName);
        }
        public TimeSpan GetPlayingTime()
        {
            TimeSpan sumtm = new TimeSpan();
            foreach (Track item in Tracks)
            {
                sumtm += item.Length;
            }
            return sumtm;
            
        }
    }
}
