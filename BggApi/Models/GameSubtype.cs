using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace BggApi.Models
{
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(AnonymousType = true)]
  public class GameSubtype
  {
    [XmlAttribute("value")]
    public string Value { get; set; }
  }
}