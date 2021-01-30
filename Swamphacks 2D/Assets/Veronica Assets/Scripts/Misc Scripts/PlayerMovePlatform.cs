using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovePlatform : MonoBehaviour 
 {
    private Vector3 velocity;
    private bool moving;

    void OnTriggerEnter2D (Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            moving = true;
            other.transform.SetParent(transform);
        }
    }
    void OnTriggerExit2D (Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            other.transform.SetParent(null);
        }
    }
    private void FixedUpdate() 
    {
        if(moving) {
            transform.position += (velocity * Time.deltaTime);
        }
    }
    
 }