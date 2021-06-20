using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShiba : MonoBehaviour
{
    bool changeDirection = false;  
    public GameObject player; 
    public float speed = 3; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x <= -25 || this.transform.position.x >= 25) {
            changeDirection = !changeDirection; 
        } 
        if (changeDirection) { 
            this.transform.position = new Vector2(this.transform.position.x + speed * Time.deltaTime, this.transform.position.y); 
        }
        if (!changeDirection) { 
            this.transform.position = new Vector2(this.transform.position.x - speed * Time.deltaTime, this.transform.position.y); 
        } 
        
        // if (rect1.y < rect2.y + rect2.height && rect1.y + rect1.height > rect2.y) 
        // check if player is on same platform as enemy 
        // if (this.transform.position.y < GetComponent<Player>().transform.position.y + GetComponent<Player>().transform.localScale.y && this.transform.position.y + this.transform.localScale.y > GetComponent<Player>().transform.position.y) {
        if (this.transform.position.y < player.transform.position.y + player.transform.localScale.y && this.transform.position.y + this.transform.localScale.y > player.transform.position.y) {
            speed += 0.01f; 
            if (this.transform.position.x <= player.transform.position.x || this.transform.position.x >= player.transform.position.x) {
                // changeDirection = !changeDirection; 
            }
        } else {
            speed = 3; 
        }
    } 

    void OnTriggerEnter2D(Collider2D other) {
        // Debug.Log("enemy-wolf collision with " + other.tag); 
        if (other.tag == "Player") {
            if (other.GetComponent<Player>().attacking) {
                other.GetComponent<Player>().killedShiba = true; 
                // other.GetComponent<Player>().isPoisoned = true; 
                Destroy(this.gameObject); 
            } else {
                other.GetComponent<Player>().health -= 2; 
            }
        } 
    } 
}
