using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject player = null;
    [SerializeField] Camera buildCam = null;
    [SerializeField] GameObject buildUI = null;
    [SerializeField, Tooltip("In seconds")] float maxTime = 100f;
    float currPhaseTime = 0f;
    GameState currState;
    BuildState buildState;
    FPSState fpsState;

    private static GameManager instance;
    public static GameManager Instance
    {
        get
        {
            return instance;
        }
    }
    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        fpsState = new FPSState(maxTime, player);
        buildState = new BuildState(maxTime, buildUI, buildCam);
        currState = buildState;
        currPhaseTime = currState.TimeToLive;
    }
    private void Update()
    {
        HandleTimeouts();
        if(Input.GetKeyDown(KeyCode.T))
        {
            SetState(GameStates.BuildState);
        }
    }

    private void HandleTimeouts()
    {
        currPhaseTime -= Time.deltaTime;
        if (currPhaseTime > 0)
            return;

        if(currState == buildState)
            SetState(GameStates.FPSState);
        if (currState == fpsState)
            SetState(GameStates.BuildState);

        currPhaseTime = currState.TimeToLive;
    }

    internal void SetState(GameStates newState)
    {
        currState.EndState();

        switch(newState)
        {
            case GameStates.BuildState:
                currState = buildState;
                break;
            case GameStates.FPSState:
                currState = fpsState;
                break;
            case GameStates.DeadState:
                Debug.Log("Odpalování Pentagonu zahájeno...");
                currState = null;
                break;
            default:
                Debug.LogError("oopsie you fucky up");
                break;
        }

        currState.StartState();
    }
    internal enum GameStates
    {
        BuildState,
        FPSState,
        DeadState
    }
}
