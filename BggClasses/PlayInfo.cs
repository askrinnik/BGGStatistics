using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace BggClasses
{
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(AnonymousType = true)]
  public class PlayInfo
  {
    [XmlElement("item")]
    public GameInfo Game { get; set; }

    [XmlArray("players")]
    [XmlArrayItem("player", IsNullable = false)]
    public PlayerInfo[] Players { get; set; }

    [XmlAttribute("id")]
    public uint Id { get; set; }

    [XmlAttribute(AttributeName = "date", DataType = "date")]
    public DateTime Date { get; set; }

    [XmlAttribute("quantity")]
    public byte Quantity { get; set; }

    [XmlAttribute("length")]
    public byte Length { get; set; }

    [XmlAttribute("incomplete")]
    public byte Incomplete { get; set; }

    [XmlAttribute("nowinstats")]
    public byte NoWinStats { get; set; }

    [XmlAttribute("location")]
    public string Location { get; set; }
  }
}