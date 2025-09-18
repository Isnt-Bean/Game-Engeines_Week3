using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    public Rigidbody fireBallPrefab;
    public movePlayer p;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Rigidbody clone;
            clone = Instantiate(fireBallPrefab, transform.position, transform.rotation);
            clone.velocity = transform.TransformDirection(Vector3.forward * 2);
        }
    }
}
