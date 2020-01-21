using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector2 input;

    public float moveSpeed;

    private Vector2 movement;

    void Update()
    {
        SetInput();
        Move();

    }

    public void SetInput()
    {
        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");
    }

    public void Move()
    {

        movement.x = input.x * moveSpeed * Time.deltaTime;
        movement.y = input.y * moveSpeed * Time.deltaTime;

        transform.position += new Vector3(movement.x, movement.y, 0);
    }
}