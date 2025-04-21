using UnityEngine;

public class PlayerState
{
    protected PlayerStateMachine stateMachine;
    protected Player player;

    private string animBoolName;

    // 상태 생성자
    public PlayerState(Player _player, PlayerStateMachine _stateMachine, string _animBoolName)
    {
        this.player = _player;
        this.stateMachine = _stateMachine;
        this.animBoolName = _animBoolName;
    }

    // 상태 진입 시 호출
    public virtual void Enter()
    {
        Debug.Log("Enter " + animBoolName);
    }

    // 상태 업데이트 시 호출
    public virtual void Update()
    {
        Debug.Log("Update " + animBoolName);
    }

    // 상태 종료 시 호출
    public virtual void Exit()
    {
        Debug.Log("Exit " + animBoolName);
    }
}
