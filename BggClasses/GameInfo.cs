using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace BggClasses
{
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(AnonymousType = true)]
  public class GameInfo
  {
    [XmlArray("subtypes")]
    [XmlArrayItem("subtype", IsNullable = false)]
    public GameSubtype[] SubTypes { get; set; }

    [XmlAttribute("name")]
    public string Name { get; set; }

    [XmlAttribute("objecttype")]
    public string ObjectType { get; set; }

    [XmlAttribute("objectid")]
    public uint ObjectId { get; set; }
  }
}