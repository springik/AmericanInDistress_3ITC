using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager : MonoBehaviour
{
    int wood = 1000;
    int metal = 1000;
    int circuits = 1000;

    private static ResourceManager instance;
    public static ResourceManager Instance
    {
        get
        {
            return instance;
        }
    }
    private void Awake()
    {
        if(instance == null)
            instance = this;
    }

    public bool CanAfordBuilding(Building b)
    {
        if(wood - b.WoodCost < 0 || metal - b.MetalCost < 0 || circuits - b.CircuitCost < 0)
        {
            return false;
        }
        return true;
    }
    public void PayForBuilding(Building b)
    {
        wood -= b.WoodCost;
        metal -= b.MetalCost;
        circuits -= b.CircuitCost;
        Debug.Log($"Wood {wood}, Metal {metal}, Circuits {circuits}");
    }
}
