using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class BuildingManager : MonoBehaviour
{
    private static BuildingManager instance;
    public static BuildingManager Instance
    {
        get
        {
            return instance;
        }
    }
    public Building chosenBuilding { get; private set; } = null;

    private void Awake()
    {
        instance = this;
        chosenBuilding = buildings[0];
    }

    [field: SerializeField]
    internal List<Building> buildings { get; private set; } = new List<Building>();

    private void Start()
    {
        Debug.Log(Instance);
    }
    public void ChooseBuilding(Building building)
    {
        chosenBuilding = building;
    }
}
