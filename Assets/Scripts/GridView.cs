using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridView : MonoBehaviour
{
    [SerializeField]
    GridSystem gridSystem;

    [SerializeField]
    Tile tilePrefab;

    [SerializeField]
    float size;

    private void Awake()
    {
        gridSystem.TilesCreated += OnTilesCreated;
    }

    private void OnTilesCreated()
    {
        Tile t;
        for(int i = 0; i < gridSystem.Tiles.GetLength(0); i++)
        {
            for (int j = 0; j < gridSystem.Tiles.GetLength(1); j++)
            {
                t = Instantiate(tilePrefab, transform);
                t.transform.localPosition = new Vector3(i * size, 0, j * size);
                t.TileData = gridSystem.Tiles[i,j];
            }
        }
    }
}
