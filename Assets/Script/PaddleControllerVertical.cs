using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleControllerVertical : MonoBehaviour
{
    private Rigidbody rb;

    public KeyCode inputKanan;
    public KeyCode inputKiri;
    public float speed;
    public int playerHP;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePaddle(PlayerInput());
    }

    public Vector3 PlayerInput()
    {
        if (Input.GetKey(inputKanan))
        {
            return new Vector3(0, 0, speed);
        }
        else if (Input.GetKey(inputKiri))
        {
            return new Vector3(0, 0, speed * -1);
        }

        return Vector3.zero;
    }

    public void MovePaddle(Vector3 movement)
    {
        rb.velocity = movement;
    }

    public void ReducePlayerHP(int damage)
    {
        playerHP -= damage;
    }
}
