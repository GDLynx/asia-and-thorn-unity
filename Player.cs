using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int speed = 10; 
    bool teleported = false; 
    public int teleportersTaken = 0; 
    public bool attacking = false; 
    private int attackDuration = 30; 
    public float health; 
    public bool isThorn = true; 
    public bool canPhase = true; 
    public bool canPlayAsAsia = true; 
    public Sprite asiaSprite; 
    public Sprite thornSprite; 
    public SpriteRenderer spriteRenderer; 
    public bool isPoisoned; // when player kills wolf 
    public bool killedShiba; 
    public bool killedWolf; 
    public bool killedRaptor; 

    // Start is called before the first frame update
    void Start()
    {
        health = 80; 
        transform.position = new Vector2(-22.74f, -6.75f); 
        isThorn = true; 
    } 

    // Update is called once per frame
    void Update()
    {
        movement(); 
        attack();
        character(); 
        enemiesKilledEffects(); 
    }  

    public void movement() {
        if (Input.GetKey(KeyCode.D)) {
            this.transform.Translate(Vector2.right * speed * Time.deltaTime); 
        } 
        if (Input.GetKey(KeyCode.A)) {
            this.transform.Translate(Vector2.left * speed * Time.deltaTime); 
        }         
    } 
    /*
        public void OnTriggerEnter(Collider other) {
        if (other.tag == "Bullet") {
            triggeringEnemy = other.gameObject; 
            triggeringEnemy.GetComponent<Enemy>().health -= damage; 
            Destroy(this.gameObject); 
        }

        if (other.tag == "Player") {
            player.GetComponent<Player>().health -= 20; 
        }
    }
    */ 

// collision not being detected 
    public void OnTriggerEnter2D(Collider2D other) {
        // Debug.Log(other.tag);   
        if (other.tag == "Teleporter") {
            teleportersTaken -= 1; 
            // Debug.Log(teleportersTaken); 
            if (teleportersTaken == 3) { // 3 being the max teleporter count 
                // level complete 
            } 
            teleported = true; 
            // Debug.Log(this.transform.position.y);          
            // this.transform.position.y += 16 (or -= )   
            Destroy(other.gameObject); 
            float newPos = this.transform.position.y + 6f; 
            transform.position = new Vector2(this.transform.position.x - 2, newPos ); 
        } 
    }

    public void attack() {
        if (Input.GetKey(KeyCode.Space)) {
            // attack 
            // Debug.Log("spacebar [attack]"); 
            if (isThorn) {
                attacking = true; 
            } 
        } 
        if (attacking) {
            attackDuration -= 1; 
        } 
        if (attackDuration <= 0) {
            attacking = false; 
            attackDuration = 30; 
        }
    } 

    public void character() {
        if (Input.GetKeyUp(KeyCode.X)) {
            isThorn = !isThorn; 
        }  

        if (isThorn) {
            spriteRenderer.sprite = thornSprite; 
        } else {
            spriteRenderer.sprite = asiaSprite; 
        }
    } 

    public void enemiesKilledEffects() {
        if (killedShiba) {
            isPoisoned = true; 
            isThorn = true; 
            canPlayAsAsia = false; 
        } 

        if (isPoisoned) {
            health -= 0.01f; 
        } 

        if (killedRaptor) {
            canPhase = false; 
        } 

        if (killedWolf && !isThorn && isPoisoned) {
            health -= 0.01f; // not sure if this will stack with the other is poisoned check  
        } 

        if (killedShiba) {
            isPoisoned = true; 
        }

        if (killedWolf) { // not sure if i  need this 
            isPoisoned = true; 
        } 
    } 
} 
