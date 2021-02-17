using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandProcessor : MonoBehaviour
{
    bool debug = false;
    KeyInput keyInput;

    Stack<ICommand> Commands = new Stack<ICommand>();

    public GameObject MoveCommandTarg;

    public object CommandUndo { get; set; }

    public CommandProcessor() : base()
    {

    }

    private void Start()
    {
        keyInput = new KeyReleasedMap();
        Commands.Clear();
    }

    public void Update()
    {
        foreach(var item in keyInput.ReleasedKey)
        {
            if (Input.GetKey(item.Key))
                MakeCommand(item);
        }
        foreach (var item in keyInput.KeyDown)
        {
            if (Input.GetKey(item.Key))
                MakeCommand(item);
            if (Input.GetKeyUp(item.Key))
                MakeCommand(item);
        }
    }

    private void MakeCommand(KeyValuePair<KeyCode, string> item)
    {
        Command command = null;
        switch (item.Value)
        {
            case "right":
                command = new RightCommand();
                break;
            case "left":
                command = new LeftCommand();
                break;
            case "rewind":
                if(Commands.Count > 0)
                {
                    if(!MoveCommandTarg.activeSelf)
                        MoveCommandTarg.SetActive(true);
                    command = (Command)Commands.Pop();
                    if (command is ICommandUndo)
                        command = ((ICommandUndo)command).UndoCommand;
                }
                break;
        }
        
        if(command != null)
        {
            if (command is ICommandUndo)
                Commands.Push((ICommandUndo)command);
            command.Execute(MoveCommandTarg);
        }
    }
}
