using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Camera : MonoBehaviour
{
    public Transform player; 
    public float smooth = 0.3f; 
    public float height; 
    private Vector2 velocity = Vector2.zero; 
    public float rise = 0; 

    // Update is called once per frame
    void Update()
    {
        /*
        Vector2 pos = new Vector2(); 
        pos.x = player.position.x; 
        pos.y = player.position.y + height; 
        transform.position = Vector2.SmoothDamp(transform.position, pos, ref velocity, smooth);          
        */ 
        // transform.position = new Vector2(player.position.x, player.position.y); 
        rise += 1; 
        // transform.position = new Vector2(0,rise * Time.deltaTime); 
    }
}
