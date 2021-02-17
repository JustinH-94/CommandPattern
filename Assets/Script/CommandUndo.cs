using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandUndo : Command, ICommandUndo
{
    GameObject gc;
    public UndoCommand UndoCommand { get; set; }

    public CommandUndo() : base()
    {

    }

    public override void Execute(GameObject gc)
    {
        this.gc = gc;
        base.Execute(gc);
    }

    public void UnExecute()
    {
        this.UndoCommand.Execute(gc);
    }

}
