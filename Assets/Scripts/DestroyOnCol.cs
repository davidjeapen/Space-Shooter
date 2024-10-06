using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCol : MonoBehaviour
{
    [SerializeField] private GameObject pfBullet;

    void OnCollisionEnter2D(Collision2D col){
        if (col.gameObject.tag != "Player"){
            //Debug.Log("Bullet hit Object");
            // AudioSource mySource = col.gameObject.GetComponent<AudioSource>();
            // mySource.Play();
            Destroy(pfBullet);
        }
        
    }
}
