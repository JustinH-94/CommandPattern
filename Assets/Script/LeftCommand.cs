using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftCommand : CommandUndo
{
    public LeftCommand() : base()
    {
        this.CommandName = "Move Left";
        this.UndoCommand = new UndoLeftCommand(this);
    }
    public override void Execute(GameObject gc)
    {
        var targ = gc.GetComponent<PlayerMove>();
        if (targ is PlayerMove)
            targ.MoveLeft();
        base.Execute(gc);
    }
}

public class UndoLeftCommand : UndoCommand
{
    public UndoLeftCommand(CommandUndo command) : base(command)
    {

    }

    public override void Execute(GameObject gc)
    {
        var targ = gc.GetComponent<PlayerMove>();
        if (targ is PlayerMove)
            targ.MoveRight();
        base.Execute(gc);
    }
}
