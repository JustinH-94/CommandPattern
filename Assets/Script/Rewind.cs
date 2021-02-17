using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rewind : MonoBehaviour
{
    GameObject game;
    Command c;

    // Start is called before the first frame update
    void Start()
    {
        game = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Backspace))
            game.gameObject.SetActive(true);
    }

    public void GetVector(Vector3 direction)
    {
        if (direction != Vector3.zero) { }

    }
}
