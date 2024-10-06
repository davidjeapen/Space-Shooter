using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private GameObject pfBullet;

    [SerializeField] private float speed;
    
    public static bool hasCollisionOccured = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 1000 && !hasCollisionOccured){
            gameObject.transform.position += new Vector3(0,1,0) * Time.deltaTime * speed;
        } else {
            Destroy (gameObject);
        }
    }
}
