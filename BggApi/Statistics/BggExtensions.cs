using System;
using System.Collections.Generic;
using System.Linq;
using BggApi.Models;

namespace BggApi.Statistics
{
  public static class BggExtensions
  {
    public static PlayWinners[] ToPlayWinners(this PlayInfo[] plays)
    {
      return plays.Where(p => p.Players != null).Select(p =>
        new PlayWinners
        {
          PlayDate = p.Date,
          GameName = p.Game.Name,
          Place1Winners = GetWinnersForPlays(p.Players, 1),
          Place2Winners = GetWinnersForPlays(p.Players, 2),
          Place3Winners = GetWinnersForPlays(p.Players, 3),
        }
      ).ToArray();

    }

    private static string[] GetWinnersForPlays(IEnumerable<PlayerInfo> players, int place)
    {
      var groups = players.GroupBy(player => player.Score, player => player.Name).OrderByDescending(r => r.Key).ToArray();
      return groups.Length<place ? Array.Empty<string>() : groups.Skip(place-1).First().ToArray();
    }
  }
}
