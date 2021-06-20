using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{

    public GameObject teleporter; 
    /*
    // will probably use a dictionary/hashmap to keep position data 
    [
        {
            entrance: (20, 20), exit: (40, 40)
        }, 
        {
            entrance: (20, 20), exit: (40, 40)
        }, 
        {
            entrance: (20, 20), exit: (40, 40)
        } 
    ]
    */ 

    // for the meantime teleporters will be 1 sided (you can only go forwards) meaning they can be stored in an array  
    
    void Start()
    {
        /*
        // teleporter = Instantiate(teleporter.transform, new Vector2(100, 100), Quaternion.identity); 
        for (int i = 0; i < 16; i += 8) {
            Instantiate(teleporter, new Vector2(22.68f, 5.8f + i), Quaternion.identity);
        }
        */
    }

    void Update()
    {

    }
}
