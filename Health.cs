using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public GameObject player; 

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");         
    }

    // Update is called once per frame
    void Update()
    {

        // Debug.Log(transform.localScale.x); 
        float playerX = player.GetComponent<Player>().transform.position.x; 
        float playerY = player.GetComponent<Player>().transform.position.y + 1; 
        float currentHealthAsWidth = player.GetComponent<Player>().health; 
        transform.position = new Vector2(playerX, playerY); 
        if (currentHealthAsWidth >= 0) {
            playerX = player.GetComponent<Player>().transform.position.x - currentHealthAsWidth; 
            transform.localScale = new Vector2(currentHealthAsWidth/10, transform.localScale.y); 
        } 

        /*
        // float width = GetComponent<SpriteRenderer>().bounds.size.x; 
        float width = GetComponent<SpriteRenderer>().size.x;
        GetComponent<SpriteRenderer>().size += new Vector2(1000f, 100); 
        Debug.Log(width); 
        // GetComponent<SpriteRenderer>().bounds.size = new Vector2(currentHealthAsWidth, GetComponent<SpriteRenderer>().bounds.size.y); 
        */ 
    }
}
