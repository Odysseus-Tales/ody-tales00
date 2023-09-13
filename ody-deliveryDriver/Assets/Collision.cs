using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("I'm Walking over here");
        
    }
    void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("watch where you going");
        
    }
 }

