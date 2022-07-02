using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody rb;
    private BallSpawner ballSpawner;
    private bool isMoved;

    public float speed;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        ballSpawner = FindObjectOfType<BallSpawner>();
    }

    private void FixedUpdate()
    {
        MoveBall();
    }

    private void OnTriggerEnter(Collider other)
    {
        ballSpawner.RemoveBall(gameObject);
    }

    public void MoveBall()
    {
        if (isMoved)
        {
            return;
        }
        else
        {
            if (transform.position.x == 5 && transform.position.z == 5)
            {
                rb.AddForce(new Vector3(Random.Range(-4f, -2f), -0.25f, Random.Range(-4f, -2f)) * speed);
            }
            if (transform.position.x == -5 && transform.position.z == 5)
            {
                rb.AddForce(new Vector3(Random.Range(2f, 4f), -0.25f, Random.Range(-4f, -2f)) * speed);
            }
            if (transform.position.x == 5 && transform.position.z == -5)
            {
                rb.AddForce(new Vector3(Random.Range(-4f, -2f), -0.25f, Random.Range(2f, 4f)) * speed);
            }
            if (transform.position.x == -5 && transform.position.z == -5)
            {
                rb.AddForce(new Vector3(Random.Range(2f, 4f), -0.25f, Random.Range(2f, 4f)) * speed);
            }
        }
        isMoved = true;
    }
}
