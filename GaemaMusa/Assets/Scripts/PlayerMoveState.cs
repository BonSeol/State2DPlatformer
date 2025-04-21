using UnityEngine;

public class PlayerMoveState : PlayerState
{
    public PlayerMoveState(Player _player, PlayerStateMachine _stateMachine, string _animBoolName)
        : base(_player, _stateMachine, _animBoolName)
    {
    }
    public override void Enter()
    {
        base.Enter(); // 부모 클래스의 Enter() 메서드 호출
    }

    public override void Exit()
    {
        base.Exit(); // 부모 클래스의 Exit() 메서드 호출
    }

    public override void Update()
    {
        base.Update(); // 부모 클래스의 Update() 메서드 호출

        if (Input.GetKeyDown(KeyCode.M))
            player.stateMachine.ChangeState(player.idleState); // 기본 상태로 전환
    }
}
