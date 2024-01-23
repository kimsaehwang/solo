using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Command 
{
    PlayerAnimation Ani;
    Rigidbody Rig;

    public int dir;
    bool IsMove;
    bool IsJump;

    public virtual void Execute() { }
}


public class CommandLMove : Command //왼쪽이동
{
    private void Awake()
    {
        
    }
    private Transform targetTransform;
    bool IsMoving;
    public CommandLMove(Transform targetTransform)
    {
        this.targetTransform = targetTransform;
    }

    public override void Execute()
    {
        LMove();
    }

    void LMove()
    {
        targetTransform.position += Vector3.left * 2f * Time.deltaTime;
        Ani.SetIsRunning()
        Debug.Log("L이동");
    }
}

public class CommandRMove : Command //오른쪽이동
{
    private Transform targetTransform;
    bool IsMoving;

    public CommandRMove(Transform targetTransform)
    {
        this.targetTransform = targetTransform;
    }

    public override void Execute()
    {
        RMove();
    }

    void RMove()
    {

        targetTransform.position += Vector3.right * 2f * Time.deltaTime;

        Debug.Log("R이동");
    }
}

public class CommandJump : Command //점프
{
    private Transform targetTransform;

    public CommandJump(Transform targetTransform)
    {
        this.targetTransform = targetTransform;
    }

    public override void Execute()
    {
        Jump();
    }

    void Jump()
    {
        targetTransform.GetComponent<Rigidbody>().AddForce(Vector3.up * 0.5f, ForceMode.Impulse);
        Debug.Log("점프");
    }
}

public class CommandAttack : Command
{
    public override void Execute()
    {
        Attack();
    }

    void Attack()
    {
        Debug.Log("공격");
    }
}
