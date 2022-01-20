using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAi : Ai
{
    public Camera player_camera;

    public override void set_up(Mob new_parent)
    {
        base.set_up(new_parent);
        Vector3 parent_location = new_parent.loc.GetComponent<Transform>().position;
        player_camera.GetComponent<Transform>().position = new Vector3(parent_location.x, parent_location.y, (int) Layers.Camera_layer);
        player_camera.GetComponent<Transform>().parent = parent.GetComponent<Transform>();
        GetComponent<Transform>().parent = parent.GetComponent<Transform>();
    }

}
