using System;
using System.Drawing;
using System.Runtime.Serialization;

namespace DreamlandEditor.Data
{
    [Serializable]
    public class WorldObject : FileBase, ISerializable
    {
        public string ImagePath { get; set; } = null;
        public Point Location { get; set; } = new Point(0, 0);
        public Point CollisionLocation { get; set; } = new Point(0, 0);
        public Size Size { get; set; } = new Size(0, 0);
        public Size CollisionSize { get; set; } = new Size(0, 0);
        public bool IsInteractable { get; set; } = false;
        public bool IsCollidable { get; set; } = true;

        public WorldObject()
        {
        }
        public WorldObject(SerializationInfo info, StreamingContext context)
        {
            ID = info.GetString("WorldObject.ID");
            Name = info.GetString("WorldObject.Name");
            ImagePath = info.GetString("WorldObject.ImagePath");
            Location = new Point(info.GetInt32("WorldObject.LocationX"), 
                info.GetInt32("WorldObject.LocationY"));
            CollisionLocation = new Point(info.GetInt32("WorldObject.CollisionX"), 
                info.GetInt32("WorldObject.CollisionY"));
            Size = new Size(info.GetInt32("WorldObject.SizeWidth"), 
                info.GetInt32("WorldObject.SizeHeight"));
            CollisionSize = new Size(info.GetInt32("WorldObject.CollisionWidth"), 
                info.GetInt32("WorldObject.CollisionHeight"));
            IsInteractable = info.GetBoolean("WorldObject.Interactable");
            IsCollidable = info.GetBoolean("WorldObject.Collidable");
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("WorldObject.ID", ID, typeof(string));
            info.AddValue("WorldObject.Name", Name, typeof(string));
            info.AddValue("WorldObject.ImagePath", ImagePath, typeof(string));
            info.AddValue("WorldObject.LocationX", Location.X, typeof(int));
            info.AddValue("WorldObject.LocationY", Location.Y, typeof(int));
            info.AddValue("WorldObject.CollisionX", CollisionLocation.X, typeof(int));
            info.AddValue("WorldObject.CollisionY", CollisionLocation.Y, typeof(int));
            info.AddValue("WorldObject.SizeWidth", Size.Width, typeof(int));
            info.AddValue("WorldObject.SizeHeight", Size.Height, typeof(int));
            info.AddValue("WorldObject.CollisionWidth", CollisionSize.Width, typeof(int));
            info.AddValue("WorldObject.CollisionHeight", CollisionSize.Height, typeof(int));
            info.AddValue("WorldObject.Interactable", IsInteractable, typeof(bool));
            info.AddValue("WorldObject.Collidable", IsCollidable, typeof(bool));
        }

        public override string ToString()
        {
            return $"ID: {ID}\nName: {Name}\nImagePath: {ImagePath}\nLocation: {Location}";
        }
    }
}
