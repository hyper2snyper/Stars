using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileHandler : MonoBehaviour
{
    Tile[,] tiles;


    public int world_height = 10;
    public int world_width = 10;

    public int player_start_x = 5; //Starting position for the player.
    public int player_start_y = 5;

    public float sprite_distance = 10f;


    public void create_world(TypeDictionary types, PlayerAi playerAi)
    {
        tiles = new Tile[world_height, world_width];
        for (int x = 0; x < world_height; x++)
        {
            for (int y = 0; y < world_height; y++)
            {
                var type = types.getTile(0);
                if(x == 0 || x == world_width-1 || y == 0 || y == world_height-1) type = types.getTile(1);
                
                Tile tile = Tile_Creator.Spawn(type, x, y, sprite_distance, GetComponent<Transform>());
                tiles[x , y] = tile;
                if(x == player_start_x && y == player_start_y)
                {
                    Mob player = Mob_Creator.Spawn(types.getMob(0), tile, playerAi);
                }
            }
        }
    }

}
