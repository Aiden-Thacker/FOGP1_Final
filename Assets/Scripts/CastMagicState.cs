using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SuperPupSystems.StateMachine;
using Unity.VisualScripting;

[System.Serializable]
public class CastMagicState : SimpleState
{
    private GameObject gameObject;
    public GameObject wand;
    public float time;
    public override void OnStart()
    {
        time = 0;
        gameObject = stateMachine.gameObject;
        Debug.Log("The name of the GameObject is " + gameObject.name);
        
        if(wand == false)
        {
            return;
        }
    }

    // Update is called once per frame
    public override void UpdateState(float _dt)
    {
        
        time += _dt;

        if (time > 2.0f)
        {
            stateMachine.ChangeState("ChaseState");
        }
    }
    public override void OnExit ()
    {

    }
}
