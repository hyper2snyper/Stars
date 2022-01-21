using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Tile : MonoBehaviour
{
    public string object_name;
    public int x;
    public int y;

    public List<object> contents;

    public bool passable = true;

    public virtual bool can_enter(Mob enterer)
    {
        return passable;
    }

    public virtual bool can_exit(Mob exiter)
    {
        return true;
    }

    public virtual void on_enter(Mob enterer)
    {

    }



}

public static class Tile_Creator
{
    public static Tile Spawn(Tile type, int x_loc, int y_loc, float sprite_distance, Transform parent)
    {
        Tile tile = Tile.Instantiate(type);
        tile.x = x_loc;
        tile.y = y_loc;
        tile.GetComponent<Transform>().parent = parent;
        tile.GetComponent<Transform>().position = new Vector3(tile.x/sprite_distance, tile.y/sprite_distance, (int) Layers.Tile_layer);
        tile.name = $"{tile.object_name} ({tile.x}, {tile.y})";
        tile.contents = new List<object>();
        return tile;
    }
}
