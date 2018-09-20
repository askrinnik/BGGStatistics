using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace BggClasses
{
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(AnonymousType = true)]
  [XmlRoot(ElementName = "plays", Namespace = "", IsNullable = false)]
  public class PlayCollection
  {
    /// <remarks/>
    [XmlElement("play")]
    public PlayInfo[] Plays { get; set; }

    [XmlAttribute("username")]
    public string UserName { get; set; }

    [XmlAttribute("userid")]
    public uint UserId { get; set; }

    [XmlAttribute("total")]
    public ushort Total { get; set; }

    [XmlAttribute("page")]
    public byte Page { get; set; }

    [XmlAttribute("termsofuse")]
    public string TermsOfUse { get; set; }
  }
}