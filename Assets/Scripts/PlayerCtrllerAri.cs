using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrllerAri : MonoBehaviour
{
    Command button_A, button_D, button_Space;
    private void Start()
    {
        InitCommand();
    }


    void InitCommand()
    {
        button_A = new CommandLMove(this.transform);
        button_D = new CommandRMove(this.transform);
        button_Space = new CommandJump(this.transform);
    }
    private void Update()
    {
        if (Input.GetKey("a")) button_A.Execute();
        if (Input.GetKey("d")) button_D.Execute();
        if (Input.GetKey("space")) button_Space.Execute();
    }
}
