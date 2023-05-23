using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int chickenCount;
    public AudioSource ChickenSound;
    private void Start()
    {
        Bullet.hitCounter = 0;

        Chicken[] chickens = FindObjectsOfType<Chicken>();
        chickenCount = chickens.Length;
        
    }


}
