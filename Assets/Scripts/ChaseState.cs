using System.Collections;
using System.Collections.Generic;
using SuperPupSystems.StateMachine;
using Unity.VisualScripting;
using UnityEngine;

[System.Serializable]
public class ChaseState : SimpleState
{
    public GameObject target;
    public float speed = 5.0f;
    public float attackRange = 2.0f;
    public string attackStateName;
    private GameObject gameObject;
    private TargetingSystem targetingSystem;
    public override void OnStart()
    {
        gameObject = stateMachine.gameObject;
        targetingSystem = gameObject.GetComponent<TargetingSystem>();
    }

    public override void UpdateState(float _dt)
    {
        // Find target
        if(targetingSystem.targetPriority)
        {
            target = targetingSystem.FindTargetPriority();
        }else
        {
            target = targetingSystem.FindTarget();
        }
        

        if (target == false)
            return;

        // Check if in range for attack state
        float distance = Vector3.Distance(target.transform.position, gameObject.transform.position);

        if (distance < attackRange)
        {
            stateMachine.ChangeState(attackStateName);
            return;
        }

        // Face Target
        gameObject.transform.LookAt(target.transform);

        // Move Forward Toward Target
        gameObject.transform.position += gameObject.transform.forward * speed * _dt;
    }

    public override void OnExit()
    {

    }
}
