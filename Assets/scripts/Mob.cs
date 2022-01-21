using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob : MonoBehaviour
{
    public string object_name;
    public int integrity;

    public Tile loc;

    public Ai brain;

    public int x;
    public int y;

}

public static class Mob_Creator
{
    public static Mob Spawn(Mob type, Tile spawn_location, Ai brain)
    {
        Mob mob = Mob.Instantiate(type);
        mob.loc = spawn_location;
        Tile loc = mob.loc;
        mob.x = loc.x;
        mob.y = loc.y;
        Transform parent_transform = loc.GetComponent<Transform>();
        mob.GetComponent<Transform>().parent = parent_transform;
        mob.GetComponent<Transform>().position = new Vector3(parent_transform.position.x, parent_transform.position.y, (int) Layers.Mob_layer);
        mob.name = $"{mob.object_name} ({loc})";
        loc.contents.Add(mob);

        mob.brain = brain;
        mob.brain?.set_up(mob);

        return mob;
    }
}
