using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyUp(KeyCode.Space)){
            
            Vector3 vector = gameObject.transform.position;
            Instantiate(bullet, vector - new Vector3(342, 100,0), Quaternion.identity);

        }
    }

    
}
