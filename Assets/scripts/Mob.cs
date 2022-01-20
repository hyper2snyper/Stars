using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob : MonoBehaviour
{
    public string object_name;
    public int integrity;

    public Tile loc;

    public Ai brain;

    public int start_x = 5;
    public int start_y = 5;

    public int x;
    public int y;

    public void create(Tile location)
    {
        loc = location;
        x = loc.x;
        y = loc.y;
        Transform parent_transform = loc.GetComponent<Transform>();
        GetComponent<Transform>().parent = parent_transform;
        GetComponent<Transform>().position = new Vector3(parent_transform.position.x, parent_transform.position.y, (int) Layers.Mob_layer);
        name = $"{object_name} ({loc})";
        loc.contents.Add(this);
    }
}
