using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    
    int count = 2;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //blockColor.color = new Color(255, 100, 100);
        //blockColor.color = new Color(255,255,255);
        print(collision.gameObject.name);
        GetComponent<SpriteRenderer>().color = new Color(0, 0, 0);
        count--;
        if(count==0)
        {
            Destroy(gameObject); 
        }
    }
 
}
