using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    [SerializeField] AudioClip clickSound;
   private int count=0;
   private Collider2D _collider2D;

    private void OnTriggerEnter2D(Collider2D other)
    {
       if( other.gameObject.CompareTag("Collectible"))
        {
            Debug.Log(count);
            count++;
            AudioSource.PlayClipAtPoint(clickSound, other.transform.position);
            Destroy(other.gameObject);

        }
        
    }



}
