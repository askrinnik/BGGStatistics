using System.Collections.Generic;
using System.Threading.Tasks;
using BggApi.Models;

namespace BggApi.Clients
{
  public class BggClient
  {
    private readonly IBggReader _reader;

    public BggClient(IBggReader reader)
    {
      _reader = reader;
    }

    public async Task<IEnumerable<PlayInfo>> LoadPlays(string userName)
    {
      var playList = new List<PlayInfo>();
      var pageNum = 1;
      var restCount = int.MaxValue;

      while (restCount > 0)
      {
        var plays = await _reader.LoadPlays(userName, pageNum);
        playList.AddRange(plays.Plays);

        if(restCount == int.MaxValue)
          restCount = plays.Total;

        restCount -= plays.Plays.Length;
        pageNum++;
      }

      return playList;
    }


  }
}
