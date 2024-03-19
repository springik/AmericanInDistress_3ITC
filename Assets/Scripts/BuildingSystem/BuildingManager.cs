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
    Building chosenBuilding = null;

    private void Awake()
    {
        instance = this;
    }

    [SerializeField]
    internal List<Building> buildings { get; private set; } = new List<Building>();

    private void Start()
    {
        Debug.Log(Instance);
    }
    void ChooseBuilding(Building building)
    {
        chosenBuilding = building;
    }
}
