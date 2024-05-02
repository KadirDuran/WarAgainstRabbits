using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject effect;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name!= "bulletPoint" && other.gameObject.name != "MGMain")
        {
            if (other.gameObject.tag == "Enemy")
            {
                //enemy'nin canýný azalt
                Destroy(other.gameObject);
            }
            Instantiate(effect,other.transform.position,Quaternion.identity);
            Destroy(gameObject);
        }
    
    }
}
