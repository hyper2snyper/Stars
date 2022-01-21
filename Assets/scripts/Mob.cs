using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob : MonoBehaviour
{
    public string object_name;
    public int integrity;

    public Tile loc;

    public Ai brain;

    public int x
    {
        get { return loc?.x; }
    }
    public int y
    {
        get { return loc?.y; }
    }

    public void forceMove(Tile new_location)
    {
        loc.contents -= this;
        loc = new_location;
        Transform parent_transform = loc.GetComponent<Transform>();
        GetComponent<Transform>().parent = parent_transform;
        GetComponent<Transform>().position = new Vector3(parent_transform.position.x, parent_transform.position.y, (int) Layers.Mob_layer);
        loc.contents += this;
    }

    public void takeStep(Tile new_location)
    {
        if(!loc.can_exit(this)) return;
        if(!new_location.can_enter(this)) return;
        forceMove(new_location);
        loc.on_enter(this);
    }

}

public static class Mob_Creator
{
    public static Mob Spawn(Mob type, Tile spawn_location, Ai brain)
    {
        Mob mob = Mob.Instantiate(type);
        mob.forceMove(spawn_location);
        mob.brain = brain;
        mob.brain?.set_up(mob);

        return mob;
    }
}
