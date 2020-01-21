using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector2 input;

    public float moveSpeed;

    public PlayerAnimation playerAnimation;

    private Vector2 movement;

    void Update()
    {
        SetInput();
        Move();
        ChangeDirection();
        CheckMoving();
    }

    public void CheckMoving()
    {
        if(movement != Vector2.zero)
        {
            playerAnimation.playerAnimator.SetBool("Walking", true);
        }
        else
        {
            playerAnimation.playerAnimator.SetBool("Walking", false);
        }
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

    public void ChangeDirection()
    {
        playerAnimation.SetWalkingDirection(movement);
        //SetWalkingDirection();
    }
}