using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    public TileHandler tiles;
    public TypeDictionary types;

    public PlayerAi player;

    void Start()
    {
        tiles = Instantiate(tiles);
        tiles.create_world(types, player);
    }

}
