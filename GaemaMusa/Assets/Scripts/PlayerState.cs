using UnityEngine;

public class PlayerState
{
    protected PlayerStateMachine stateMachine;
    protected Player player;

    private string animBoolName;

    // ���� ������
    public PlayerState(Player _player, PlayerStateMachine _stateMachine, string _animBoolName)
    {
        this.player = _player;
        this.stateMachine = _stateMachine;
        this.animBoolName = _animBoolName;
    }

    // ���� ���� �� ȣ��
    public virtual void Enter()
    {
        Debug.Log("Enter " + animBoolName);
    }

    // ���� ������Ʈ �� ȣ��
    public virtual void Update()
    {
        Debug.Log("Update " + animBoolName);
    }

    // ���� ���� �� ȣ��
    public virtual void Exit()
    {
        Debug.Log("Exit " + animBoolName);
    }
}
