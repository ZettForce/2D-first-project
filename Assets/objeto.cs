using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objeto : MonoBehaviour
{
    // Start is called before the first frame update
   public void OnTriggerEnter2D(Collider2D collision) 
   {
       if (collision.CompareTag("Player"))
       {
           GetComponent<SpriteRenderer>().enabled = false;
           Destroy(gameObject, 0.5f);
       }
   }
}
