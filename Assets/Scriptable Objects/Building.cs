using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Building", menuName = "ScriptableObjects/Building")]
public class Building : ScriptableObject
{
    [field: SerializeField]
    int metalCost;
    public int MetalCost { get { return metalCost; } }
    [field: SerializeField]
    int woodCost;
    public int WoodCost { get { return woodCost; } }
    [field: SerializeField]
    int circuitCost;
    public int CircuitCost { get { return circuitCost; } }

    [field: SerializeField] public string buildingName {  get; private set; }
    [field: SerializeField] public GameObject prefab {  get; private set; }
}
