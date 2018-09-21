using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using BggApi.Models;

namespace BggApi.Clients
{
  public class BggFileReader: IBggReader
  {
    private readonly string _fileName;

    public BggFileReader(string fileName)
    {
      _fileName = fileName;
    }

    public Task<PlayCollection> LoadPlays(string userName, int page)
    {
      var serializer = new XmlSerializer(typeof(PlayCollection));

      using (var reader = new StreamReader(_fileName))
        return Task.FromResult((PlayCollection) serializer.Deserialize(reader));
    }
  }
}
