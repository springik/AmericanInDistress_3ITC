using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildState : GameState
{
    GameObject UI;
    Camera cam;

    public BuildState(float timeToLive, GameObject UI, Camera cam) : base(timeToLive)
    {
        this.UI = UI;
        this.cam = cam;
    }

    public override void StartState()
    {
        UI.SetActive(true);
        cam.gameObject.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
    }
    public override void EndState()
    {
        UI.SetActive(false);
        cam.gameObject.SetActive(false);
    }
}
