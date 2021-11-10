using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    [Tooltip("the distance jump with player")]
    [SerializeField] private float distance;

    [Tooltip("the Animator for animation player")]
    [SerializeField] private Animator animator;

    [Tooltip("the borders of the map (left,right,down,up)")]
    [SerializeField] private Collider2D[] colliderBorders;// [0] = LeftBorder, [1] = RightBorder, [2] = DownBorder, [3] = UpBorder

    [Tooltip("the KeyCode that the player move (up,down,left,right)")]
    [SerializeField] private KeyCode[] keyCode; // keyCode[0] = up, keyCode[1] = down, keyCode[2] = down,
                                                // 
    private const int movingUp = 0; // moving up number
    private const int movingDown = 1; // moving down number
    private const int movingLeft = 2; // moving left number
    private const int movingRight = 3; // moving right number

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(keyCode[movingUp]) && colliderBorders[3].transform.position.y > transform.position.y)
        {
            animator.SetBool("MoveUp", true); // play the move up animation
            animator.SetBool("StandDown", false);
            transform.position += Vector3.up * distance; // jumping up

        }
        else if (Input.GetKeyUp(keyCode[movingUp]))
        {
            animator.SetBool("StandUp", true); // play the stand up animation
            animator.SetBool("MoveUp", false);
        }
        if (Input.GetKeyDown(keyCode[movingDown]) && colliderBorders[2].transform.position.y < transform.position.y)
        {
            animator.SetBool("MoveDown", true); // play the move down animation
            animator.SetBool("StandUp", false);
            transform.position += Vector3.down * distance; // jumping down

        }
        else if (Input.GetKeyUp(keyCode[movingDown]))
        {
            animator.SetBool("StandDown", true); // play the stand down animation
            animator.SetBool("MoveDown", false);
        }

        if (Input.GetKeyDown(keyCode[movingLeft]) && colliderBorders[0].transform.position.x < transform.position.x)
        {
            transform.position += Vector3.left * distance; // jumping left 

        }
        if (Input.GetKeyDown(keyCode[movingRight]) && colliderBorders[1].transform.position.x > transform.position.x)
        {

            transform.position += Vector3.right * distance; // jumping right

        }



    }
}
