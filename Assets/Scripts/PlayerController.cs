using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject bulletSpawnPosition;
    public float speed;
    public int lives = 3;
    public GameObject losePopup;
    public GameObject[] hearts;
    public AudioSource Shooting;
    public float ShootingDelay = 1;
    private bool isMouseClicked =true
        ;
    //public float randomnumber;
    private void Start()
    {
        //InvokeRepeating("ShootBullets", 1f, 0.5f);
        StartCoroutine("ShootBullets1");

    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isMouseClicked = true;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            isMouseClicked = false;
        }

        // Move();
        //MoveonMobileDevice();       
        ////if (Input.GetKeyDown(KeyCode.Space)) 
        ////{      
        //    Instantiate(bulletPrefab, bulletSpawnPosition.transform.position, Quaternion.identity); // Quaternion.identity - bez rotacija
        ////    Shooting.Play();
        ////}
    }

    private void InvokeRepeating(GameObject bulletPrefab, float v1, float v2)
    {
        throw new NotImplementedException();
    }

    private void MoveonMobileDevice()
    {
        if (Input.GetMouseButton(0))
        {
            

            Debug.Log(Input.mousePosition);
            float midScreenX = Screen.width / 2;
            Debug.Log(midScreenX);
            if(Input.mousePosition.x < midScreenX)
            {
                Vector3 position = transform.position;
                position.x -= speed;
                transform.position = position;
            }
            else
            {

                Vector3 position = transform.position;
                position.x += speed;
                transform.position = position;
            }
        }

    }


    //private void Move()
    //{
    //    float horizontalAxis = Input.GetAxis("Horizontal");
    //    Vector3 position = transform.position;
    //    position.x += speed * horizontalAxis;
    //    transform.position = position;
    //}


    private void OnTriggerEnter2D(Collider2D other)
    {
        lives--;
        Debug.Log("Lives = " + lives);
        Destroy(other.gameObject);

        

        hearts[lives].SetActive(false);

        
        if (lives <= 0) 
        {
            
            losePopup.SetActive(true); // vkluci to losePopup
            Destroy(gameObject);// unisti go player-ot
        }
    }
    private IEnumerator ShootBullets1()
    {
        while (true)
        {
            yield return new WaitForSeconds(ShootingDelay);
            if (isMouseClicked)
            {
                ShootBullets();
            }
            Instantiate(bulletPrefab, bulletSpawnPosition.transform.position, Quaternion.identity);

        }
    }

   private void ShootBullets()
    {
        Instantiate(bulletPrefab, bulletSpawnPosition.transform.position, Quaternion.identity);
    }
}
