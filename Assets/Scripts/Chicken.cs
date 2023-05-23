using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : MonoBehaviour
{
    public float speed = 0.01f;
    public bool isMovingLeft = true;
    public GameObject eggPrefab;

    private void Start()
    {
        StartCoroutine(CreateEggs());
        //float randomNumber = Random.Range(1f, 4f);
        //Debug.Log(randomNumber);
        //InvokeRepeating("CreateEgg", 1f, randomNumber);
    }

    // Korutini - Coroutines - funkcii vo koj moze da dodavame delay
    private IEnumerator CreateEggs()
    {
        while (true)
        {
            float randomNumber = Random.Range(2f, 5f);
            
            yield return new WaitForSeconds(randomNumber);
            CreateEgg();
        }
    }

    public void CreateEgg()
    {
        Instantiate(eggPrefab, transform.position, Quaternion.identity); //Quaternion.identity - bez rotacija
    }

    private void Update()
    {
        if (isMovingLeft) // dokolku isMovingLeft e true, dvizi se na levo
        {
            Vector3 pos = transform.position;
            pos.x -= speed;
            transform.position = pos;
        }
        else // dokolku isMovingLeft = false
        {
            Vector3 pos = transform.position;
            pos.x += speed;
            transform.position = pos;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag != "Chicken"&& other.gameObject.tag != "Egg")
        {
            // smeni nasoka
            isMovingLeft = !isMovingLeft; // flip-ni ja vrednosta na promenlivata
        }
    }
}
