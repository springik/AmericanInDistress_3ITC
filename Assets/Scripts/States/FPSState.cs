using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSState : GameState
{
    GameObject player;
    GameObject gun;

    public FPSState(float timeToLive, GameObject player) : base(timeToLive)
    {
        this.player = player;
    }

    public override void EndState()
    {
        player.SetActive(false);
        gun = GameObject.FindGameObjectWithTag("Weapon");
        gun.SetActive(false);
    }

    public override void StartState()
    {
        player.SetActive(true);

        if(gun != null)
            gun.SetActive(false);
    }
}
