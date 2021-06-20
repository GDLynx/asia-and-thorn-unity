using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBackground : MonoBehaviour
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
        // technically i don't need this script 
        float playerX = player.GetComponent<Player>().transform.position.x; 
        float playerY = player.GetComponent<Player>().transform.position.y + 1; 
        transform.position = new Vector2(playerX, playerY); 
    }
}
