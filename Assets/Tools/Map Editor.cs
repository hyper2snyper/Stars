using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MapEditor : EditorWindow
{

    Tile[,] tiles;

    public int width = 10;
    public int height = 10;

    [MenuItem ("Window/Map Editor %#e")]
    static void  Init () 
    {
        EditorWindow.GetWindow (typeof (MapEditor));
    }

    void  OnEnable () {

    }

    void  OnGUI () {
        tiles = new Tile[width, height];
        if(GUILayout.Button("Save Map"))
        {
            MapCreator.Create(tiles);
        }

        for (int x = 0; x < height; x++)
        {
            EditorGUILayout.BeginHorizontal();
            for (int y = 0; y < height; y++)
            {
                EditorGUILayout.BeginVertical();
                tiles[x , y] = EditorGUILayout.ObjectField (tiles[x,y], typeof (Tile), false) as Tile;
                EditorGUILayout.EndVertical();
            }
            EditorGUILayout.EndHorizontal();
        }

    }

}

public class MapCreator
{
    public static void Create(Tile[,] tiles)
    {
        MapFile asset = ScriptableObject.CreateInstance<MapFile>();
        asset.tiles = tiles;
        AssetDatabase.CreateAsset(asset, "Assets/MapFile.asset");
        AssetDatabase.SaveAssets();

    }
}
