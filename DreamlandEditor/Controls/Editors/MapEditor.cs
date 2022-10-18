using DreamlandEditor.Components;
using DreamlandEditor.Data;
using DreamlandEditor.Data.Enums;
using DreamlandEditor.Data.GameFiles;
using DreamlandEditor.ExtensionClasses;
using DreamlandEditor.Handlers;
using DreamlandEditor.Managers;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGame.Forms.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using DreamlandEditor.Data.GameFiles.Objects;
using DreamlandEditor.Data.GameFiles.Characters;

namespace DreamlandEditor.Controls.Editors
{
  public class MapEditor : MonoGameControl, IBaseEditor
  {
    public string EditorFor { get; set; } = FileTypesEnum.Map.ToString();
    public bool IsLoaded { get; set; } = false;
    public bool IsDragging { get; set; } = false;
    public bool IsCollisionDrawn { get; set; } = false;
    public BaseObject ItemInQueue { get; set; } = null;
    public MouseState CurrentMouseState { get; set; }
    public MouseState LastMouseState { get; set; }
    public Vector2 CurrentMousePosition { get; set; }
    public KeyboardState CurrentKeyboardState { get; set; }
    public KeyboardState LastKeyboardState { get; set; }
    public Camera Camera { get; set; }
    public Map MapFile { get; set; }
    public System.Windows.Forms.Label CursorPositionLabel { get; set; }
    public System.Windows.Forms.Label ZoomAmountLabel { get; set; }

    private bool _shouldUpdateMouse;

    private DrawingHandler _drawingHandler;

    protected override void Initialize()
    {
      base.Initialize();
      Camera = new Camera(Editor.graphics);
      MapFile = new Map();
    }

    public void LoadMap(Map obj)
    {
      MapFile = obj;
      _drawingHandler = new DrawingHandler(Editor.spriteBatch);
      LoadTextures<WorldObject>(ItemsManager.GetTiles());
      LoadTextures<WorldObject>(ItemsManager.WorldObjects);
      LoadTextures<WorldObject>(ItemsManager.Characters);
      foreach (WorldObject item in MapFile.WorldObjects)
      {
        string name = item.ImagePath == null ?
          ImagePaths.NotFound :
          Path.Combine(SystemPrefsManager.SystemPrefs.RootPath, item.ImagePath);
        item.Texture = Editor.Content.Load<Texture2D>(name.Replace(Path.GetExtension(name), ""));
      }
      LoadTextures<WorldObject>(MapFile.Tiles);
      LoadTextures<WorldObject>(MapFile.WorldObjects);
      LoadTextures<WorldObject>(MapFile.Characters);

      IsLoaded = true;
    }
    private void LoadTextures<T>(IEnumerable<BaseObject> objects)
    {
      foreach (BaseObject item in objects)
      {
        string name = String.IsNullOrEmpty(item.ImagePath) ?
          ImagePaths.NotFound :
          Path.Combine(SystemPrefsManager.SystemPrefs.RootPath, item.ImagePath);
        item.Texture = Editor.Content.Load<Texture2D>(name.Replace(Path.GetExtension(name), ""));
      }
    }
    #region UPDATE
    protected override void Update(GameTime gameTime)
    {
      base.Update(gameTime);
      if (!IsLoaded || !IsMouseInsideControlArea(0, 0, Width, Height)) return;
      _shouldUpdateMouse = IsMouseInsideControlArea(Location.X, Location.Y, Width, Height);

      CurrentMouseState = Mouse.GetState();
      CurrentKeyboardState = Keyboard.GetState();
      GetCurrentMousePosition();
      RemoveObject();
      ObjectPlacement();
      HandleKeyboardInput();
      Camera.Update(gameTime, Width, Height);
      SetLabels();
      LastMouseState = CurrentMouseState;
      LastKeyboardState = CurrentKeyboardState;
    }
    private void GetCurrentMousePosition()
    {
      CurrentMousePosition = new Vector2(CurrentMouseState.Position.X, CurrentMouseState.Position.Y);
    }
    private Vector2 TranslateMousePosition(Vector2 position)
    {
      return Vector2.Transform(position, Matrix.Invert(Camera.Transform));
    }
    private void ObjectPlacement()
    {
      if (CurrentMouseState.LeftButton == ButtonState.Pressed && LastMouseState.LeftButton == ButtonState.Released &&
         IsDragging && ItemInQueue != null)
      {
        if (ItemInQueue.FileType.Equals(FileTypesEnum.WorldObject.ToString()))
        {
          PlaceWorldObject(ItemInQueue as WorldObject);
        }
        else if (ItemInQueue.FileType.Equals(FileTypesEnum.Tile.ToString()))
        {
          PlaceTile(ItemInQueue as Tile);
        }
        else if (ItemInQueue.FileType.Equals(FileTypesEnum.Character.ToString()))
        {
          PlaceCharacter(ItemInQueue as BaseCharacter);
        }
      }
    }
    private void PlaceWorldObject(WorldObject item)
    {
      Vector2 centeredPosition = CenterMousePosition(item);
      Vector2 transformedMousePosition = TranslateMousePosition(centeredPosition);
      item.Position = new System.Drawing.Point((int)transformedMousePosition.X, (int)transformedMousePosition.Y);
      WorldObject newItem = new WorldObject(item);
      CountZIndex(newItem);
      MapFile.WorldObjects.Add(newItem);
    }
    private void PlaceCharacter(BaseCharacter character)
    {
      Vector2 centeredPosition = CenterMousePosition(character);
      Vector2 transformedMousePosition = TranslateMousePosition(centeredPosition);
      character.Position = new System.Drawing.Point((int)transformedMousePosition.X, (int)transformedMousePosition.Y);
      BaseCharacter newCharacter = new BaseCharacter(character);
      CountZIndex(newCharacter);
      MapFile.Characters.Add(newCharacter);
    }
    private void PlaceTile(Tile item)
    {
      Vector2 mousePosition = new Vector2(
        CurrentMousePosition.X - CurrentMousePosition.X % item.Size.Width,
        CurrentMousePosition.Y - CurrentMousePosition.Y % item.Size.Height);
      Vector2 transformedMousePosition = GetSnapToGridPosition(mousePosition, item.Size.Width, item.Size.Height);
      item.Position = new System.Drawing.Point((int)transformedMousePosition.X, (int)transformedMousePosition.Y);
      Tile newItem = new Tile(item);
      Tile removeableObject = MapFile.DoesItemIntersectOthers(newItem) as Tile;
      if (removeableObject != null)
      {
        MapFile.Tiles.Remove(removeableObject);
      }
      if (newItem.TileType == TileTypesEnum.Elevated.ToString())
      {
        CountZIndex(newItem);
      }
      MapFile.Tiles.Add(newItem);
    }
    private Vector2 CenterMousePosition(BaseObject item)
    {
      return new Vector2(CurrentMousePosition.X - item.Size.Width, CurrentMousePosition.Y - item.Size.Height);
    }
    private void CountZIndex(BaseFile item)
    {
      if(item.FileType == FileTypesEnum.Tile.ToString())
      {
        Tile tileItem = item as Tile;
        tileItem.ZIndex = tileItem.Position.Y + tileItem.Size.Height;
      }
      else if (item.FileType == FileTypesEnum.WorldObject.ToString())
      {
        WorldObject objectItem = item as WorldObject;
        objectItem.ZIndex = objectItem.Position.Y + objectItem.Size.Height;
      }
    }
    private List<BaseObject> GetObjectsUnderCursor()
    {
      List<BaseObject> hoveredOverObjects = new List<BaseObject>();
      List<BaseObject> mapObjects = MapFile.WorldObjects.Cast<BaseObject>().Union(MapFile.Characters).ToList();
      for (int i = 0; i < mapObjects.Count; i++)
      {
        if (mapObjects[i].CursorIntersects(TranslateMousePosition(CurrentMousePosition)))
        {
          hoveredOverObjects.Add(mapObjects[i]);
        }
      }
      if (hoveredOverObjects.Count < 1)
      {
        for (int i = 0; i < MapFile.Tiles.Count; i++)
        {
          if (MapFile.Tiles[i].CursorIntersects(TranslateMousePosition(CurrentMousePosition)))
          {
            hoveredOverObjects.Add(MapFile.Tiles[i]);
          }
        }
      }
      return hoveredOverObjects;
    }
    private Vector2 GetSnapToGridPosition(Vector2 position, int itemWidth, int itemHeight)
    {
      Vector2 transformedPosition = TranslateMousePosition(position);
      float x = transformedPosition.X - transformedPosition.X % itemWidth;
      float y = transformedPosition.Y - transformedPosition.Y % itemHeight;
      if (position.X < 0)
      {
        x = transformedPosition.X + transformedPosition.X % itemWidth;
      }
      if (position.Y < 0)
      {
        y = transformedPosition.Y + transformedPosition.Y % itemHeight;
      }
      return new Vector2(x, y);
    }

    private void HandleKeyboardInput()
    {
      if (CurrentKeyboardState.IsKeyDown(Keys.C) && LastKeyboardState.IsKeyUp(Keys.C))
      {
        IsCollisionDrawn = !IsCollisionDrawn;
      }
    }

    private void SetLabels()
    {
      CursorPositionLabel.Text =
        $"X:{Math.Floor(TranslateMousePosition(CurrentMousePosition).X / 32)} " +
        $"- Y:{Math.Floor(TranslateMousePosition(CurrentMousePosition).Y / 32)}";
      ZoomAmountLabel.Text =
        $"{Camera.GetZoomPercentage()}%";
    }
    #endregion
    #region DRAW
    protected override void Draw()
    {
      base.Draw();
      if (!IsLoaded) return;

      Editor.spriteBatch.Begin(transformMatrix: Camera.Transform);

      CurrentMouseState = Mouse.GetState();
      CurrentKeyboardState = Keyboard.GetState();

      DrawObjects();
      DrawDraggedImage(Width, Height);
      if (!IsMouseInsideControlArea(0, 0, Width, Height))
      {
        Editor.spriteBatch.End();
        return;
      }
      ClickOnObject();

      LastMouseState = CurrentMouseState;
      LastKeyboardState = CurrentKeyboardState;

      Editor.spriteBatch.End();
    }
    private void DrawObjects()
    {
      if (MapFile.Tiles != null && MapFile.WorldObjects != null)
      {
        List<BaseObject> mapObjects = MapFile.Tiles.Cast<BaseObject>()
          .Union(MapFile.WorldObjects)
          .Union(MapFile.Characters)
          .OrderBy(x => x.ZIndex)
          .ToList();
        foreach (BaseObject file in mapObjects)
        {
          Editor.spriteBatch.Draw(file.Texture, new Vector2(file.Position.X, file.Position.Y), Color.White);
          if (!file.IsCollidable) continue;
          DrawCollision(file);
        }
      }
    }
    private void DrawCollision(BaseObject obj)
    {
      if (!IsCollisionDrawn) return;
      _drawingHandler.DrawRectangle(obj.GetCollision(), Color.Red, 1);
    }
    private void DrawDraggedImage(int screenWidth, int screenHeight)
    {
      if (ItemInQueue == null ||
        (CurrentMouseState.Position.X < 0 || CurrentMouseState.Position.X > screenWidth ||
        CurrentMouseState.Position.Y < 0 || CurrentMouseState.Position.Y > screenHeight)) return;
      BaseObject item = ItemInQueue;
      Vector2 mousePosition = new Vector2(CurrentMouseState.Position.X, CurrentMouseState.Position.Y);
      if (ItemInQueue.FileType == FileTypesEnum.Tile.ToString())
      {
        mousePosition = new Vector2(
          mousePosition.X - mousePosition.X % item.Size.Width,
          mousePosition.Y - mousePosition.Y % item.Size.Height);
        Vector2 transformedMousePosition = GetSnapToGridPosition(mousePosition, item.Size.Width, item.Size.Height);
        Editor.spriteBatch.Draw(ItemInQueue.Texture, transformedMousePosition, Color.White);
        DrawGrid(transformedMousePosition, item);
        return;
      }
      Vector2 centeredPosition = new Vector2(
        mousePosition.X - item.Size.Width,
        mousePosition.Y - item.Size.Height);
      Editor.spriteBatch.Draw(ItemInQueue.Texture, Vector2.Transform(centeredPosition, Matrix.Invert(Camera.Transform)), Color.White);
    }
    private void DrawGrid(Vector2 mousePosition, BaseObject item)
    {
      for (int i = -item.Size.Width; i <= item.Size.Width; i += item.Size.Width)
      {
        for (int j = -item.Size.Height; j <= item.Size.Height; j += item.Size.Height)
        {
          _drawingHandler.DrawRectangle(new Rectangle((int)mousePosition.X + i, (int)mousePosition.Y + j,
            item.Size.Width, item.Size.Height), Color.Red, 1);
        }
      }
    }
    private void ClickOnObject()
    {
      if (IsDragging) return;
      BaseObject upperObject = GetObjectsUnderCursor().OrderByDescending(x => x.ZIndex).FirstOrDefault();
      if (upperObject == null) return;
      if(upperObject.FileType == FileTypesEnum.Tile.ToString())
      {
        Tile tile = (Tile)upperObject;
        _drawingHandler.DrawRectangle(new Rectangle(upperObject.Position.X, upperObject.Position.Y,
          tile.Size.Width, tile.Size.Height), Color.Aquamarine, 2);
      }
      else 
      {
        BaseObject obj = upperObject;
        _drawingHandler.DrawRectangle(new Rectangle(upperObject.Position.X, upperObject.Position.Y,
          obj.Size.Width, obj.Size.Height), Color.Aquamarine, 2);
      }

      if (CurrentMouseState.LeftButton == ButtonState.Pressed /*&& LastMouseState.LeftButton == ButtonState.Released*/)
      {
        MoveObjectOnMap(upperObject);
      }
      if (CurrentMouseState.RightButton == ButtonState.Pressed /*&& LastMouseState.RightButton == ButtonState.Released*/)
      {
        RemoveObjectFromCollection(upperObject);
      }
    }
    private void MoveObjectOnMap(BaseObject upperObject)
    {
      ItemInQueue = upperObject;
      RemoveObjectFromCollection(upperObject);
      IsDragging = true;
    }
    private void RemoveObjectFromCollection(BaseFile upperObject)
    {
      if (IsDragging) return;
      if (upperObject.FileType == FileTypesEnum.WorldObject.ToString())
        MapFile.WorldObjects.Remove(upperObject as WorldObject);
      if (upperObject.FileType == FileTypesEnum.Tile.ToString())
        MapFile.Tiles.Remove(upperObject as Tile);
      if (upperObject.FileType == FileTypesEnum.Character.ToString())
        MapFile.Characters.Remove(upperObject as BaseCharacter);
    }
    private void RemoveObject()
    {
      if (CurrentKeyboardState.IsKeyDown(Keys.Q) &&
        LastKeyboardState.IsKeyUp(Keys.Q) && IsDragging)
      {
        IsDragging = false;
        ItemInQueue = null;
        return;
      }
    }
    #endregion

    public void GetLabels(System.Windows.Forms.Label cursorPosition, System.Windows.Forms.Label zoomAmount)
    {
      CursorPositionLabel = cursorPosition;
      ZoomAmountLabel = zoomAmount;
    }
  }
}
