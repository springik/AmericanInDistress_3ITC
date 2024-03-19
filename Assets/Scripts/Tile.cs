using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField]
    GameObject building;
    public TileData TileData { get; set; }

    internal void SetBuilding(GameObject building)
    {
        building.transform.SetParent(transform);
        building.transform.localPosition = new Vector3(1.25f, 0, 1.25f);
    }

    private void OnMouseDown()
    {
        //var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);

        //Debug.Log(cube);

        var cmd = new BuildCommand(
            building,
            this
            );

        CommandQueue.Instance.AddCommand(cmd);
    }
}
