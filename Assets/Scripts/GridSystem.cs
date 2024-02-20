using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSystem : MonoBehaviour
{
    [SerializeField]
    private int size = 20;

    TileData[,] tiles;
    public TileData[,] Tiles => tiles;

    public event Action TilesCreated;

    void Start()
    {
        tiles = new TileData[size, size];
        for (int i = 0; i < size; i++) { 
            for (int j = 0; j < size; j++)
            {
                tiles[i, j] = new TileData() { 
                    x = i, y = j, isOccupied = false
                };
            }
        }

        TilesCreated?.Invoke();
    }
}

public class TileData
{
    public int x;
    public int y;
    public bool isOccupied;
}
