using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EBDestroyOnCol : MonoBehaviour
{
   [SerializeField] private GameObject pfBullet;

    void OnCollisionEnter2D(Collision2D col){
        if (col.gameObject.tag != "Enemy"){
            //Debug.Log("Enemy bullet hit object");
            // AudioSource mySource = col.gameObject.GetComponent<AudioSource>();
            // mySource.Play();
            Destroy(pfBullet);
        }
        
    }
}
