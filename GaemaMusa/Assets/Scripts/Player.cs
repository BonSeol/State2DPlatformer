using UnityEngine;

public class Player : MonoBehaviour
{
    // 상태 머신 인스턴스
    public PlayerStateMachine stateMachine { get; private set; }

    // 플레이어의 상태들
    public PlayerIdleState idleState { get; private set; }
    public PlayerMoveState moveState { get; private set; }

    private void Awake()
    {
        // 상태 머신 초기화
        stateMachine = new PlayerStateMachine();

        // 상태 인스턴스 생성
        idleState = new PlayerIdleState(this, stateMachine, "Idle");
        moveState = new PlayerMoveState(this, stateMachine, "Move");
    }

    private void Start()
    {
        // 초기 상태 설정
        stateMachine.Initialize(idleState);
    }

    private void Update()
    {
        // 현재 상태의 업데이트 메서드 호출
        stateMachine.currentState.Update();
    }
}
