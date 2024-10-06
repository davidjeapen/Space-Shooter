using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private int health;

    void OnCollisionEnter2D(Collision2D col){
        if (col.gameObject.tag == "Wall"){
            // Debug.Log("Collision Detected");
            // AudioSource mySource = col.gameObject.GetComponent<AudioSource>();
            // mySource.Play();
        }else if (col.gameObject.tag == "eBullet"){
            Debug.Log($"Player has been shot: {health} lives left");
            health--;
        }else if (col.gameObject.tag == "Enemy"){
            health--;
            Debug.Log($"Player ran into enemy: {health} lives left");
        }

        if (health == 0){
            Debug.Log("You lose");
            Destroy(gameObject);

        }
        
        //Destroy(col.gameObject);
    }


}
