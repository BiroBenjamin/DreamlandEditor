using System;

namespace DreamlandEditor.Data.GameFiles.Objects
{
  [Serializable]
  public class WorldObject : BaseObject
  {
    public bool IsInteractable { get; set; } = false;

    public WorldObject() { }
    public WorldObject(BaseObject baseObject) : base(baseObject) { }
    public WorldObject(WorldObject worldObject) : base(worldObject) 
    {
      IsInteractable = worldObject.IsInteractable;
    }
  }
}
