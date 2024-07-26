using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Xoaytron : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float rotationSpeed = 100f;

    void Update()
    {
        Quaternion increnentalRotation = Quaternion.Euler(x: 0f, y: 0f, z: -rotationSpeed * Time.deltaTime);
        transform.localRotation *= increnentalRotation;
    }
}
