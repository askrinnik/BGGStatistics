using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using BggClasses;

namespace ConsoleApp4
{
  class Program
  {
    static void Main(string[] args)
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
