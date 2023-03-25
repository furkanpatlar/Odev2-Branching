using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] AudioClip clickSound;
    private int count = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Collectible"))
        {
            count++;
            //Debug.Log(count);
            AudioSource.PlayClipAtPoint(clickSound,other.transform.position);
            Destroy(other.gameObject);
        }
    }
}
