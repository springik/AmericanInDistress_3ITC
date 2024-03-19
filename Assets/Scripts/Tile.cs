using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public TileData TileData { get; set; }

    internal void SetBuilding(GameObject building)
    {
        building.transform.SetParent(transform);
        building.transform.localPosition = Vector3.zero;
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
