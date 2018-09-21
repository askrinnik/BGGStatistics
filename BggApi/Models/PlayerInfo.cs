using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace BggApi.Models
{
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(AnonymousType = true)]
  public class PlayerInfo
  {
    [XmlAttribute("username")]
    public string UserName { get; set; }

    [XmlAttribute("userid")]
    public uint UserId { get; set; }

    [XmlAttribute("name")]
    public string Name { get; set; }

    [XmlAttribute("startposition")]
    public byte StartPosition { get; set; }

    [XmlAttribute("color")]
    public string Сolor { get; set; }

    [XmlAttribute("score")]
    public ushort Score { get; set; }

    [XmlAttribute("new")]
    public byte New { get; set; }

    [XmlAttribute("rating")]
    public byte Rating { get; set; }

    [XmlAttribute("win")]
    public byte Win { get; set; }
  }


}
