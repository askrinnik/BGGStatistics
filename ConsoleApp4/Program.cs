using System;
using System.IO;
using System.Xml.Serialization;
using BggApi.Models;

namespace ConsoleApp4
{
  class Program
  {
    static void Main()
    {
      PlayCollection plays;
      var path = @"D:\Downloads\plays2.xml";

      var serializer = new XmlSerializer(typeof(PlayCollection));

      using (var reader = new StreamReader(path))
      {
        plays = (PlayCollection)serializer.Deserialize(reader);
      }

      Console.WriteLine(plays.Plays.Length);
      Console.ReadLine();
    }
  }
  
}
