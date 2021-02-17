using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightCommand : CommandUndo
{
    public RightCommand():base()
    {
        this.CommandName = "Move Right";
        this.UndoCommand = new UndoRightCommand(this);
    }

    public override void Execute(GameObject gc)
    {
        var targ = gc.GetComponent<PlayerMove>();
        if (targ is PlayerMove)
            targ.MoveRight();
    }
}

public class UndoRightCommand : UndoCommand
{
    public UndoRightCommand(CommandUndo command) : base(command)
    {

    }

    public override void Execute(GameObject gc)
    {
        var targ = gc.GetComponent<PlayerMove>();
        if (targ is PlayerMove)
            targ.MoveLeft();
        base.Execute(gc);
    }
}
