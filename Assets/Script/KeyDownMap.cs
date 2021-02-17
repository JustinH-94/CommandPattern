using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDownMap : KeyInput
{
    public override void Initialize()
    {
        KeyDown.Add(KeyCode.A, "left");
        KeyDown.Add(KeyCode.D, "right");
        KeyDown.Add(KeyCode.RightArrow, "right");
        KeyDown.Add(KeyCode.LeftArrow, "Left");
        KeyDown.Add(KeyCode.Backspace, "rewind");
        base.Initialize();
    }
}
