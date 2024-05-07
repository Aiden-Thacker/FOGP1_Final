using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SuperPupSystems.StateMachine;
using Unity.VisualScripting;

[System.Serializable]
public class HammerTimeState : SimpleState
{
    public GameObject hammer;
    private GameObject gameObject;
    private Vector3 targetRotation;
    private Vector3 beginningRotation;
    private float time;
    public override void OnStart()
    {
        time = 0.0f;
        gameObject = stateMachine.gameObject;

        if (hammer == false)
            return;
        
        hammer.GetComponent<Animator>().Play("Hammer");
    }

    public override void UpdateState(float _dt)
    {
        if (hammer == false)
            return;
        
        time += _dt;

        if (time > 1.0f)
            stateMachine.ChangeState("ChaseState");
    }

    public override void OnExit()
    {

    }
}
