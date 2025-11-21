using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation_EulerAngles : MonoBehaviour {

    // Start is called before the first frame update
    void Start()
    {

    }
    public float rotationSpeed = 2;
    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles += new Vector3(rotationSpeed, 0, rotationSpeed);
    }
}
