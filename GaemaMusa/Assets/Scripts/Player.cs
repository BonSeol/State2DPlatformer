using UnityEngine;

public class Player : MonoBehaviour
{
    // ���� �ӽ� �ν��Ͻ�
    public PlayerStateMachine stateMachine { get; private set; }

    // �÷��̾��� ���µ�
    public PlayerIdleState idleState { get; private set; }
    public PlayerMoveState moveState { get; private set; }

    private void Awake()
    {
        // ���� �ӽ� �ʱ�ȭ
        stateMachine = new PlayerStateMachine();

        // ���� �ν��Ͻ� ����
        idleState = new PlayerIdleState(this, stateMachine, "Idle");
        moveState = new PlayerMoveState(this, stateMachine, "Move");
    }

    private void Start()
    {
        // �ʱ� ���� ����
        stateMachine.Initialize(idleState);
    }

    private void Update()
    {
        // ���� ������ ������Ʈ �޼��� ȣ��
        stateMachine.currentState.Update();
    }
}
