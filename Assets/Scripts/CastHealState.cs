using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SuperPupSystems.StateMachine;
using Unity.VisualScripting;

[System.Serializable]
public class CastHealState : SimpleState
{
    private GameObject gameObject;
    public GameObject staff;
    public float time;
    public override void OnStart()
    {
        time = 0;
        gameObject = stateMachine.gameObject;
        
        if(staff == false)
        {
            return;
        }
    }

    // Update is called once per frame
    public override void UpdateState(float _dt)
    {
        
        time += _dt;

        if (time > 1.0f)
        {
            stateMachine.ChangeState("ChaseState");
        }
    }
    public override void OnExit ()
    {

    }
}
