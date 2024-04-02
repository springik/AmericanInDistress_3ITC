using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BuilderUI : MonoBehaviour
{
    [SerializeField]
    GameObject buttonPrefab, buttonPanel;
    void Start()
    {
        ReloadUI();
    }

    public void ChooseBuilding(Building building)
    {
        BuildingManager.Instance.ChooseBuilding(building);
    }
    
    void ReloadUI()
    {
        for(int i = 0; i < BuildingManager.Instance.buildings.Count; i++)
        {
            Building currBuilding = BuildingManager.Instance.buildings[i];
            GameObject b = Instantiate(buttonPrefab);
            b.GetComponent<Button>().onClick.AddListener(() => { ChooseBuilding(currBuilding); });
            b.GetComponentInChildren<TMP_Text>().text = currBuilding.buildingName;
            b.transform.SetParent(buttonPanel.transform, false);
        }
    }
}
