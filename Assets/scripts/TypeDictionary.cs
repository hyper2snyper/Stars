using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/TypeDictionary", order = 1)]
public class TypeDictionary : ScriptableObject
{

    public Tile[] tiles;
    public Mob[] mobs;

    public Tile getTile(int key)
    {
        return tiles[key];
    } 

    public Mob getMob(int key)
    {
        return mobs[key];
    } 
}