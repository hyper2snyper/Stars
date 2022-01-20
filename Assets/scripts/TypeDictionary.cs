using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypeDictionary : MonoBehaviour
{
	public Tile wall;
    public Tile floor;

    Dictionary<Tiles, Tile> tiles;

    public Mob human;

    Dictionary<Mobs, Mob> mobs;

    public void generate()
    {
        tiles = new Dictionary<Tiles, Tile>();
        tiles.Add(Tiles.Wall, wall);
        tiles.Add(Tiles.Floor, floor);

        mobs = new Dictionary<Mobs, Mob>();
        mobs.Add(Mobs.Human, human);
    }


    public Tile getTile(Tiles name)
    {
        if(tiles.ContainsKey(name))
            return tiles[name];
        Debug.LogError($"Tile with {name} could not be found.");
        return null;
    } 

    public Mob getMob(Mobs name)
    {
        if(mobs.ContainsKey(name))
            return mobs[name];
        Debug.LogError($"Mob with {name} could not be found.");
        return null;
    } 
}

public enum Tiles{
    Wall,
    Floor,
}

public enum Mobs{
    Human,
}
