using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public TileData TileData { get; set; }

    internal void SetBuilding(GameObject building)
    {
        building.transform.localPosition = new Vector3(1.25f,0f, 1.25f);
    }

    private void OnMouseDown()
    {
        var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);

        Debug.Log(cube);

        var cmd = new BuildCommand(
            cube,
            this
            );

        CommandQueue.Instance.AddCommand(cmd);
    }
}
