using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Item_Collector : MonoBehaviour
{
    private int chickens = 0;    

    [SerializeField] private Text chickensText;

    [SerializeField] private AudioSource collectionSoundEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Chicken"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            chickens++;
            chickensText.text = "Items: " + chickens;
        }
    }
}
