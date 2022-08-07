using System;
using System.Drawing;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace DreamlandEditor.Data
{
    [Serializable]
    public class WorldObject : BaseFile
    {
        public Point Location { get; set; } = new Point(0, 0);
        public Point CollisionLocation { get; set; } = new Point(0, 0);
        [XmlIgnore]
        public Size BaseSize { get; private set; } = new Size(64, 64);
        public Size Size { get; set; } = new Size(64, 64);
        public Size CollisionSize { get; set; } = new Size(0, 0);
        public bool IsInteractable { get; set; } = false;
        public bool IsCollidable { get; set; } = true;

        public WorldObject()
        {

        }

        public override string ToString()
        {
            return $"ID: {ID}\nName: {Name}\nImagePath: {ImagePath}\nLocation: {Location}";
        }
    }
}
