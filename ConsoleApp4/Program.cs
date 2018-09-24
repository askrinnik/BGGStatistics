using System;
using System.Linq;
using BggApi.Clients;
using BggApi.Models;
using BggApi.Statistics;

namespace ConsoleApp4
{
  class Program
  {
    static void Main()
    {
      var plays = ReadFromWeb();
      //var plays = new[]
      //{
      //  new PlayInfo
      //  {
      //    Date = DateTime.Now,
      //    Game = new GameInfo {Name = "ddd"},
      //    Players = new[]
      //    {
      //      new PlayerInfo {Name = "11", Score = 100},
      //      new PlayerInfo {Name = "12", Score = 100},
      //      new PlayerInfo {Name = "2", Score = 90},
      //      new PlayerInfo {Name = "3", Score = 95},
      //    }
      //  }
      //};

      Console.WriteLine(plays.Length);

      var winners = plays.ToPlayWinners();

      Console.ReadLine();
    }

    private static PlayInfo[] ReadFromWeb()
    {
      var reader = new BggHttpReader();
      var client = new BggClient(reader);
      var plays = client.LoadPlays("MirrorBoy").Result.ToArray();

      return plays;
    }

    private static PlayInfo[] ReadFromFile()
    {
      const string path = @"D:\Downloads\plays3.xml";

      var reader = new BggFileReader(path);
      var plays = reader.LoadPlays(null, 0).Result;

      return plays.Plays;
    }
  }
  
}
