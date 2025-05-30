using UnityEngine;

public class Skill : MonoBehaviour
{
    [SerializeField] private float cooldown;
    protected float cooldownTimer;

    protected virtual void Update()
    {
        cooldownTimer -= Time.deltaTime;
    }

    public virtual bool CanUseSkill()
    {
        if (cooldownTimer < 0)
        {
            UseSkill();
            cooldownTimer = cooldown;
            return true;
        }
        Debug.Log("Skill is on cooldown");

        return false;
    }

    public virtual void UseSkill()
    {
        //��ų���
    }
}
