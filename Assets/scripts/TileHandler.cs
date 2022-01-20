using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileHandler : MonoBehaviour
{
    Tile[,] tiles;


    public int world_height = 10;
    public int world_width = 10;

    public float sprite_distance = 10f;


    public void create_world(TypeDictionary types, PlayerAi playerAi)
    {
        tiles = new Tile[world_height, world_width];
        Mob player = Instantiate(types.getMob(Mobs.Human));
        for (int x = 0; x < world_height; x++)
        {
            for (int y = 0; y < world_height; y++)
            {
                var type = types.getTile(Tiles.Floor);
                if(x == 0 || x == world_width-1 || y == 0 || y == world_height-1) type = types.getTile(Tiles.Wall);
                
                Tile tile = Instantiate(type);
                tile.set_up(x, y, sprite_distance, GetComponent<Transform>());
                tiles[x , y] = tile;
                if(x == player.start_x && y == player.start_y)
                {
                    player.create(tile);
                    player.brain = playerAi;
                    playerAi.set_up(player);
                }
            }
        }
    }

}
