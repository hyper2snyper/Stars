using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public string object_name;
    public int x;
    public int y;

    public List<object> contents;

    public void set_up(int x_loc, int y_loc, float sprite_distance, Transform parent)
    {
        x = x_loc;
        y = y_loc;
        GetComponent<Transform>().parent = parent;
        GetComponent<Transform>().position = new Vector3(x/sprite_distance, y/sprite_distance, (int) Layers.Tile_layer);
        name = $"{object_name} ({x}, {y})";
        contents = new List<object>();
    }
}
