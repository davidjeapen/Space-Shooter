using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] private GameObject enemy;
    
    public static int enemyCount = 0;
    [SerializeField] private Canvas mainCanvas;
    private GameObject newObject;
    

  
    // Start is called before the first frame update
    void Start()
    {
        int width = (int) mainCanvas.GetComponent<RectTransform>().rect.width;
        int height = (int) mainCanvas.GetComponent<RectTransform>().rect.height;
        int spawnX = -width/2 + width/9;
        int spawnY = height/2 - height/8;
        for (int j = 0; j < 3; j++){
            for (int i = 0; i < 10; i++){
                newObject = Instantiate(enemy, new Vector3 (spawnX, spawnY, 0), Quaternion.identity);
                Debug.Log(newObject.tag);
                enemyCount++;
                spawnX += width/14;
            }
            if (j % 2 == 0){
                spawnX = -width/2 + width/7;
            }else
            {
                spawnX = -width/2 + width/9;
            }
            spawnY -= height/8;
        }
    }
}
