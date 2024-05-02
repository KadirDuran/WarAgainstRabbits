using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{

    public Transform enemyPoint1, enemyPoint2,bulletPoint,bpc;
    public GameObject enemy1, enemy2,bullet;
   
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy3s", 0f, 9f);
    }
    void SpawnEnemy3s()
    {
        int rand = Random.RandomRange(0, 2);
        if (rand == 0)
        {
            GameObject g = Instantiate(enemy1, enemyPoint1.transform.position, Quaternion.identity);
            g.transform.Rotate(g.transform.rotation.x, 180f, 0f);
           
        }
        else
        {
            GameObject g = Instantiate(enemy2, enemyPoint2.transform.position, Quaternion.identity);
            g.transform.Rotate(g.transform.rotation.x, 180f, 0f);
        }

    }
    public void SpawnBullet()
    {
       GameObject bulletx =  Instantiate(bullet, bpc.transform.position,bulletPoint.transform.rotation);
    }
}
