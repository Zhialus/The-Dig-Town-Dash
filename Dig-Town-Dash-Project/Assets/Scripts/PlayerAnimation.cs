using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    public Animator playerAnimator;

    public void SetWalkingDirection(Vector2 newDirection)
    {
        playerAnimator.SetFloat("Vertical", newDirection.y);
        playerAnimator.SetFloat("Horizontal", newDirection.x);
    }
}
