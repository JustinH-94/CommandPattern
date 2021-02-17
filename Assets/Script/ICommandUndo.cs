using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICommandUndo : ICommand
{
    UndoCommand UndoCommand { get; set; }
}

