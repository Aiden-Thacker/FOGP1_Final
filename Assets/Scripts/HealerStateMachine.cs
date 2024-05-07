using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SuperPupSystems.StateMachine;

public class HealerStateMachine : SimpleStateMachine
{
    public IdleState idleState;
    public ChaseState chaseState;
    public CastHealState castHealState;
    void Awake()
    {
        states.Add(idleState);
        states.Add(chaseState);
        states.Add(castHealState);

        ChangeState(nameof(idleState));
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
