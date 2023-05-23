using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{
    public GameObject winPopup;   
    private Text scoreText;
    public static int hitCounter = 0; // sega ovaa promenliva e povrzana so samata klasa, ne so instancite/objektite


    void Start()
    {
       
        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.tag == "Enemy1") // ako other e bulet, ignoriraj go
            {
                Destroy(other.gameObject); // unisti go drugio objekt
                Destroy(gameObject);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Chicken") // ako other e bulet, ignoriraj go
        {
            Destroy(other.gameObject); // unisti go drugio objekt
            Destroy(gameObject); // unisti se samiot sebe (kursumot)
            //Debug.Log("Bullet:OnTriggerEnter. hitCounter before hit = " + hitCounter);
            // logika za zgolemuvanje na skorot
            hitCounter++;
            Debug.Log("Bullet:OnTriggerEnter. hitCounter after hit = " + hitCounter);

            GameManager FindChicken =FindObjectOfType<GameManager>();
        if(hitCounter >= FindChicken.chickenCount )
            {
                WinPopup winPopup = FindObjectOfType<WinPopup>(true);
                winPopup.gameObject.SetActive(true);
               
            }
            //prikazi ja novata vrednost na hitCounter na ekranot
            scoreText.text = $"{hitCounter}";

        }
    }
}
