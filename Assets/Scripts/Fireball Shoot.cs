using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballShoot : MonoBehaviour
{
    public Rigidbody rb;
    public static FireballShoot Instance { get; private set; }
    // Start is called before the first frame update
    void Awake()
    {
        StartCoroutine(fireballStart());
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    
    IEnumerator fireballStart()
    {
        rb.AddForce(Vector3.up, ForceMode.Impulse);
        rb.AddForce(Vector3.right * 5, ForceMode.Impulse);
        yield return new WaitForSeconds(1.5f);
        Destroy(gameObject);
    }
}
