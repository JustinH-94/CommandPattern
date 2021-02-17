using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    GameObject startPos;

    // Start is called before the first frame update
    void Start()
    {
        startPos = GameObject.FindGameObjectWithTag("Start Position");
        this.transform.position = startPos.transform.position;
    }
}
