using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyInput
{
    public Dictionary<KeyCode, string> ReleasedKey, KeyDown;
    public KeyInput()
    {
        ReleasedKey = new Dictionary<KeyCode, string>();
        KeyDown = new Dictionary<KeyCode, string>();
        this.Initialize();
    }

    public virtual void Initialize() { }
}
