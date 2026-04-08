using System;
using System.Collections.Generic;
using System.Text;

namespace Modul6_103022400081
{
    internal class SayaMusicUser
    {
        private int id;
        public string username;
        private List<SayaMusicTrack> uploadedTracks;

        public SayaMusicUser(string username)
        {
            Random rand = new Random();
            this.id = rand.Next(10000, 99999);
            this.username = username;
            this.uploadedTracks = new List<SayaMusicTrack>();
        }
        public int GetTotalPlayCount()
        {
            int totalPlayCount = 0;
            foreach (SayaMusicTrack track in uploadedTracks)
            {
                totalPlayCount += track.GetPlayCount();

            }
            return totalPlayCount;

        }
        public void addTrack(SayaMusicTrack track)
        {
            uploadedTracks.Add(track);
        }
        public void PrintAllTracks()
        {
            Console.WriteLine("User: " + username);
            for (int i=0; i< 8; i++)
            {
                Console.WriteLine($"Track: {i+1} judul: {uploadedTracks[i].getTitle()}");
            }   
        }
    }
}
            
            
            
            
            
            
            
            
            
            
            
            
            






















