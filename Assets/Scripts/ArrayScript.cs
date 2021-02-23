using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayScript : MonoBehaviour
{
    public GameObject brick;
    //float offset;
    public GameObject[  ] brickArray = new GameObject[5];
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0;i<5;i++)
        {
           
            for(int j=0;j<5;j++)
            {
                transform.position = new Vector3(transform.position.x +2.5f, transform.position.y, 0);
                brickArray[ j] = Instantiate(brick, transform.position, Quaternion.identity);
            }
            
            transform.position =new Vector3(0,8.0f,0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
