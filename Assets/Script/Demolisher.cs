using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demolisher : MonoBehaviour
{
    enum DemolisherState { Wait, Destroy, CoolDown}
    DemolisherState demoState;

    Vector3 originalPos;

    float downSpeed = 7.0f;
    float upSpeed = 2.0f;
    float accuracy = .01f;
    public bool findPlayer;
    // Start is called before the first frame update
    void Start()
    {
        
        this.demoState = DemolisherState.Wait;
        findPlayer = false;
        this.originalPos = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    { 
        DemolisherSwitch();
    }

    void DemolisherSwitch()
    {
        switch (demoState)
        {
            case DemolisherState.Wait:
                DemolisherWait();
                break;
            case DemolisherState.Destroy:
                DemolisherMoveDown();
                break;
            case DemolisherState.CoolDown:
                DemolisherCoolDown();
                break;
        }
    }

    void DemolisherWait()
    {
        if (findPlayer)
            this.demoState = DemolisherState.Destroy;
    }

    void DemolisherCoolDown()
    {
        if (Vector2.Distance(transform.position, originalPos) > accuracy)
            this.transform.position += new Vector3(this.transform.position.x, upSpeed * Time.deltaTime, this.transform.position.z);
        else if (Vector2.Distance(transform.position, originalPos) <= accuracy)
        {
            this.demoState = DemolisherState.Wait;
            findPlayer = false;
        }
    }

    void DemolisherMoveDown()
    {
        if (this.demoState == DemolisherState.Destroy)
            this.transform.position -= new Vector3(this.transform.position.x, downSpeed * Time.deltaTime, this.transform.position.z);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "White Platform")
            this.demoState = DemolisherState.CoolDown;
    }
}
