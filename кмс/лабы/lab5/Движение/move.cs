using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{   
    public float speedX = 0.1f;
    public float speedY= 0.2f;
    public float speedZ = 0.3f;

    void Update()
    {
        transform.position += new Vector3(speedX, speedY, speedZ);
    }
}