using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour, ICommandComponent
{
    float speed = 5.0f;
    string k;
    SpriteRenderer sprite;
    // Start is called before the first frame update
    void Start()
    {
 
        sprite = GetComponent<SpriteRenderer>();
        sprite.flipX = true;
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void MoveRight()
    {
        this.transform.position -= Vector3.left *speed* Time.deltaTime;
        sprite.flipX = false;
        
    }

    public void MoveLeft()
    {
        this.transform.position -= Vector3.right * speed * Time.deltaTime;
        sprite.flipX = true;
    }



}
