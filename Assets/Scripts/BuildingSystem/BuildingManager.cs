using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class BuildingManager : MonoBehaviour
{
    static BuildingManager instance;
    public static BuildingManager Instance
    {
        get
        {
            return instance;
        }
    }
    internal Building chosenBuilding { get; private set; } = null;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Debug.LogWarning("Multiple singletons");
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
