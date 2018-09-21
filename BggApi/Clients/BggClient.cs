using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
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

      var plays = await _reader.LoadPlays(userName, 1);
      playList.AddRange(plays.Plays);


      int restCount = plays.Total;
      var pageNum = 1;

      restCount -= plays.Plays.Length;
      pageNum++;

      while (restCount > 0)
      {
        plays = await _reader.LoadPlays(userName, pageNum);
        playList.AddRange(plays.Plays);

        restCount -= plays.Plays.Length;
        pageNum++;
      }

      return playList;
    }


  }
}
