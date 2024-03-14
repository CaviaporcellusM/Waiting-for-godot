using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDefendState : PlayerGroundedState
{
    public PlayerDefendState(Player _player, PlayerStateMachine _stateMachine, string _animBoolName) : base(_player, _stateMachine, _animBoolName)
    {

    }

    public override void Enter()
    {
        base.Enter();
    }

    public override void Exit()
    {
        base.Exit();
        stateMachine.ChangeState(player.idleState);
    }

    public override void Update()
    {
        base.Update();
    }
}
