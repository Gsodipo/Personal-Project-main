using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    int coins = 0;
    public AudioSource coinSound;
    public void OnTriggerEnter(Collider other)
    {
          if(other.gameObject.CompareTag("Coin"))
          {
              Destroy(other.gameObject);
              coins++;
              Debug.Log("Coins: " + coins);
              coinSound.Play();
          }
     }
}
