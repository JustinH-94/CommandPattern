using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public interface ICommandComponent
{
    void MoveLeft();
    void MoveRight();
}

public class CommandComponent : ICommandComponent
{
    public virtual void MoveLeft()
    {
        throw new NotImplementedException();
    }

    public virtual void MoveRight()
    {
        throw new NotImplementedException();
    }
}
