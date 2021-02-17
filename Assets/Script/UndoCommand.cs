using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UndoCommand : Command
{
    public UndoCommand(CommandUndo command)
    {
        this.CommandName = "Undo " + command.CommandName;
    }
}
