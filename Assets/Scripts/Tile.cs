using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public TileData TileData { get; set; }

    private void OnMouseDown()
    {
        gameObject.SetActive(false);
    }
}
