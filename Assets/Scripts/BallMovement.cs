using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallMovement : MonoBehaviour
{
    private PaddleMovement PaddleMovement;
  //  float distanceX = 0.02f;
    float distanceY = 0.91f;
    Rigidbody2D ballRB;
    bool start;
    // Start is called before the first frame update
    void Start()
    {
        PaddleMovement = GameObject.Find("Paddle").GetComponent<PaddleMovement>();
        ballRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
    if(Input.GetMouseButtonDown(0) && start==false)
        {
            ballRB.velocity = new Vector2(0, 15);
            start = true;
        }
    if(start==false)
        {
            transform.position = new Vector2(PaddleMovement.transform.position.x, PaddleMovement.transform.position.y + distanceY);
        }
    }
}
