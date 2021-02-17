using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyReleasedMap : KeyInput
{
    public override void Initialize()
    {
        ReleasedKey.Add(KeyCode.A, "left");
        ReleasedKey.Add(KeyCode.RightArrow, "right");
        ReleasedKey.Add(KeyCode.D, "right");
        ReleasedKey.Add(KeyCode.LeftArrow, "left");
        ReleasedKey.Add(KeyCode.Backspace, "rewind");
        base.Initialize();
    }
}
