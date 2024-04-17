using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameState
{
    float timeToLive;
    public float TimeToLive { get {  return timeToLive; } }
    public abstract void StartState();
    public abstract void EndState();

    public GameState(float timeToLive)
    {
        this.timeToLive = timeToLive;
    }
}
