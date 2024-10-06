using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DualShooting : MonoBehaviour
{    
    [SerializeField] private GameObject pfBullet;
    [SerializeField] private float y_pos;
    [SerializeField] private float x_adj;
    private float center = 342;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space)){
            
            Vector3 vector = gameObject.transform.position;

            Instantiate(pfBullet, vector - new Vector3(center - x_adj, y_pos,0), Quaternion.identity);
            Instantiate(pfBullet, vector - new Vector3(center + x_adj, y_pos,0), Quaternion.identity);

        }
    }

    
}
