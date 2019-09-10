using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleBullet : MonoBehaviour
{
    public float power = 10;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        rb.AddForce(transform.right * power);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //gameObject.SetActive(false);
    }
}
