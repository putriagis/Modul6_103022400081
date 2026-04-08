using System;
using System.Collections.Generic;
using System.Text;

namespace Modul6_103022400081
{
    internal class SayaMusicTrack
    {
        private int id;
        public string title;
        private int PlayCount;

        public string getTitle()
        {
            return title;
        }

        public SayaMusicTrack(string title)
        {
            Random rand = new Random();
            this.id = rand.Next(10000, 99999);
            this.title = title;
            this.PlayCount = 0;
        }
        public void IncreasePlayCount(int count)
        {
            PlayCount+=count;
        }
        public void PrintTrackDetails()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Play Count: " + PlayCount);
        }
        public int GetPlayCount()
        {
            return PlayCount;
        }
    }
}
