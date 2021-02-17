using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Command : ICommand
{
    public string CommandName;
    static bool debug = false;
    string LogString;
    public Command()
    {

    }

    public virtual void Execute(GameObject gc)
    {
        this.Log();
    }

    protected virtual string Log()
    {
        LogString = string.Format($"{CommandName}");
        if (debug)
            Debug.Log(LogString);
        return LogString;
    }
    
}
