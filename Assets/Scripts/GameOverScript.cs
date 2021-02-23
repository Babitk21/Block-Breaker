using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;
using TMPro;

public class GameOverScript : MonoBehaviour
{
    public TextMeshProUGUI GameOver;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameOver.gameObject.SetActive(true);
    }
}
