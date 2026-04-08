// See https://aka.ms/new-console-template for more information
using Modul6_103022400081;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        SayaMusicTrack musik1 = new SayaMusicTrack("lagu a");
        SayaMusicTrack musik2 = new SayaMusicTrack("lagu b");
        SayaMusicTrack musik3 = new SayaMusicTrack("lagu c");
        SayaMusicTrack musik4 = new SayaMusicTrack("lagu d");
        SayaMusicTrack musik5 = new SayaMusicTrack("lagu e");
        SayaMusicTrack musik6 = new SayaMusicTrack("lagu f");
        SayaMusicTrack musik7 = new SayaMusicTrack("lagu g");
        SayaMusicTrack musik8 = new SayaMusicTrack("lagu h");
        SayaMusicTrack musik9 = new SayaMusicTrack("lagu i");
        SayaMusicTrack musik10 = new SayaMusicTrack("lagu j");

        musik1.IncreasePlayCount(10);
        musik2.IncreasePlayCount(10);
        musik3.IncreasePlayCount(10);
        musik4.IncreasePlayCount(10);
        musik5.IncreasePlayCount(10);
        musik6.IncreasePlayCount(10);
        musik7.IncreasePlayCount(10);
        musik8.IncreasePlayCount(10);
        musik9.IncreasePlayCount(10);
        musik10.IncreasePlayCount(10);

        SayaMusicUser usr = new SayaMusicUser("putri");
        usr.addTrack(musik1);
        usr.addTrack(musik2);
        usr.addTrack(musik3);
        usr.addTrack(musik4);
        usr.addTrack(musik5);
        usr.addTrack(musik6);
        usr.addTrack(musik7);
        usr.addTrack(musik8);
        usr.addTrack(musik9);
        usr.addTrack(musik10);

        usr.PrintAllTracks();

        Console.WriteLine("total play count: " + usr.GetTotalPlayCount()); 

    }
}
