using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mousePostion = Input.mousePosition.x / Screen.width * 16.0f;
        Vector2 paddlePos = new Vector2(transform.position.x,transform.position.y);
        paddlePos.x = Mathf.Clamp(mousePostion, 1, 15);
        transform.position = paddlePos;
    }
}
