using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballShoot : MonoBehaviour
{
    public Rigidbody rb;
    
    // Start is called before the first frame update
    void Awake()
    {
        StartCoroutine(fireballStart());
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    IEnumerator fireballStart()
    {
        rb.AddForce(Vector3.up, ForceMode.Impulse);
        rb.AddForce(Vector3.right * 5, ForceMode.Impulse);
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }
}
