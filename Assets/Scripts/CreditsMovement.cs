using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsMovement : MonoBehaviour
{

    public float speed = 1f;

    private void Update()
    {
        Vector3 position = transform.localPosition;
        position.y -= speed;
        transform.localPosition = position;
        
    }
}
