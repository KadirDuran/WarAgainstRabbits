using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    public GameObject gunBody;
    
    private Vector2 baslangicPozisyonu;
    

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.touchCount>0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                baslangicPozisyonu = touch.position;
            }
            if (touch.phase == TouchPhase.Moved)
            {
                float hareketMiktari = touch.position.x - baslangicPozisyonu.x;
                if (transform.rotation.y<45 && transform.rotation.y>-45)
                {
                    if (hareketMiktari < 0)
                    {
                        gunBody.transform.Rotate(transform.rotation.x, transform.rotation.y - 1f, transform.rotation.z);
                    }
                    else
                    {
                        gunBody.transform.Rotate(transform.rotation.x, transform.rotation.y + 1f, transform.rotation.z);

                    }
                }
                
            }
        }
       
         
    }
}
