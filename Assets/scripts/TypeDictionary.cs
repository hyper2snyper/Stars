using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypeDictionary : ScriptableObject
{

    public Tile[] tiles;
    public Mob[] mobs;

    public Tile getTile(int key)
    {
        if(key <= tiles.key)
            return tiles[key];
        Debug.LogError($"Tile with key: {key} could not be found.");
        return null;
    } 

    public Mob getMob(int key)
    {
        if(key <= mobs.len)
            return mobs[key];
        Debug.LogError($"Mob with key: {key} could not be found.");
        return null;
    } 
}

public enum Tiles : int
{
    wall = 0,
    floor,
}

public enum Mobs : int
{
    human = 0,
}
