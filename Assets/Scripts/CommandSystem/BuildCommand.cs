using UnityEngine;
public class BuildCommand : Command
{
    private GameObject buildingPrefab;
    Building soBuilding;
    private Tile tile;

    public BuildCommand(Building building, Tile tile)
    {
        this.soBuilding = building;
        this.buildingPrefab = building.prefab;
        this.tile = tile;
    }

    public override void Execute()
    {
        var building = GameObject.Instantiate(buildingPrefab, tile.transform);
        ResourceManager.Instance.PayForBuilding(soBuilding);
        tile.SetBuilding(building);
    }
}
