using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Building", menuName ="ScriptableObjects/Building")]
public class Building : ScriptableObject
{
    [field: SerializeField] internal List<ResourceCost> resourceCosts { get; private set; } = new List<ResourceCost>();
    [field: SerializeField] public string buildingName {  get; private set; }
    [field: SerializeField] public GameObject prefab {  get; private set; }
}

[Serializable]
internal class ResourceCost
{
    [SerializeField] string name;
    [SerializeField] int amount;
}
