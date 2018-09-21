using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using BggApi.Models;

namespace BggApi.Clients
{
  public class BggHttpReader : IBggReader
  {
    private const string BaseUrl = "http://www.boardgamegeek.com/xmlapi2";
    private static async Task<string> ReadData(Uri requestUrl)
    {
      // Due to malformed header I cannot use GetContentAsync and ReadAsStringAsync :(
      // UTF-8 is now hard-coded...
      using (var client = new HttpClient())
      {
        var responseBytes = await client.GetByteArrayAsync(requestUrl);
        var xmlResponse = Encoding.UTF8.GetString(responseBytes, 0, responseBytes.Length);

        return xmlResponse;
      }
    }

    public async Task<PlayCollection> LoadPlays(string userName, int page)
    {
      var requestUrl = new Uri(BaseUrl + $"/plays?username={userName}&page={page}");
      var xDoc = await ReadData(requestUrl);
      var serializer = new XmlSerializer(typeof(PlayCollection));

      using (var reader = new StringReader(xDoc))
        return (PlayCollection)serializer.Deserialize(reader);
    }


  }
}
