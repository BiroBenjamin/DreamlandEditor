using System.ComponentModel;
using System.Xml.Serialization;

namespace ProjectDreamland.Data.Enums
{
  public enum CharacterAffiliationsEnum
  {
    [XmlEnum(Name = "Friendly"), Description("Friendly")]
    Friendly,
    [XmlEnum(Name = "Neutral"), Description("Neutral")]
    Neutral,
    [XmlEnum(Name = "Hostile"), Description("Hostile")]
    Hostile
  }
}
