using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOnCol : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D col){
        if (col.gameObject.tag == "Wall"){
            Debug.Log("Collision Detected");
            AudioSource mySource = col.gameObject.GetComponent<AudioSource>();
            mySource.Play();
        }else if (col.gameObject.tag == "eBullet"){
            Debug.Log("Player has been shot");
        }
        
        //Destroy(col.gameObject);
    }


}
