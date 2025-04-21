using UnityEngine;

public class PlayerIdleState : PlayerState
{
    public PlayerIdleState(Player _player, PlayerStateMachine _stateMachine, string _animBoolName)
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

        if(Input.GetKeyDown(KeyCode.N))
            player.stateMachine.ChangeState(player.moveState); // 이동 상태로 전환
    }
}
