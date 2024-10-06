using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Enemy : MonoBehaviour
{
    [SerializeField] private GameObject enemy;
    [SerializeField] private int health;
    [SerializeField] private int speed;
    [SerializeField] private GameObject pfEnemybullet;

    private System.Random random;
    //private Canvas mainCanvas;

    private bool movingLeft = true;
    private Vector3 initialPos;
    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D col){
        //Debug.Log("Shot by " + col.gameObject.tag);
        if (col.gameObject.tag == "Bullet"){
            health--;
            if (health == 0){
                Destroy(enemy);
                SpawnEnemy.enemyCount--;
                Debug.Log($"There are {SpawnEnemy.enemyCount} enemies left.");
            }
            
        }
    }

    void Start(){
        //mainCanvas = GameObject.FindWithTag("Canvas");
        initialPos = gameObject.transform.position;
        random = new System.Random();
    }

    // Update is called once per frame
    void Update()

    {
        if (random.Next(0,1000) == 1){
            Vector3 vector = gameObject.transform.position;
            Instantiate(pfEnemybullet, vector - new Vector3(0, 0,0), Quaternion.identity);
        }
        if (movingLeft){
            gameObject.transform.position += new Vector3(1,0,0) * Time.deltaTime * speed;
        }else {
            gameObject.transform.position += new Vector3(-1,0,0) * Time.deltaTime * speed;
        }
        //float width = mainCanvas.GetComponent<RectTransform>().rect.width;

        if (Math.Abs(gameObject.transform.position.x - initialPos.x) > 100){
            movingLeft = false;
        } else if (gameObject.transform.position.x < initialPos.x){
            movingLeft = true;
        }
    }
}
