using System;
using System.Linq;
using BggApi.Clients;

namespace ConsoleApp4
{
  class Program
  {
    static void Main()
    {
      ReadFromWeb();
      Console.ReadLine();
    }

    private static void ReadFromWeb()
    {
      var reader = new BggHttpReader();
      var client = new BggClient(reader);
      var plays = client.LoadPlays("MirrorBoy").Result.ToArray();

      Console.WriteLine(plays.Length);
    }

    private static void ReadFromFile()
    {
      var path = @"D:\Downloads\plays3.xml";

      var reader = new BggFileReader(path);
      var plays = reader.LoadPlays(null, 0).Result;

      Console.WriteLine(plays.Plays.Length);
    }
  }
  
}
