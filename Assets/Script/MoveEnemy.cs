using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    private float moveSpeed = 3;
    private float distanceToMove = 4f; // Distance to move to the right before turning around
    private bool movingRight = true; // Flag to track the direction of movement

    // Update is called once per frame
    private void Update()
    {
        // Calculate movement in the x-axis
        float horizontalMovement = moveSpeed * Time.deltaTime;

        if (movingRight)
        {
            // Move to the right
            transform.Translate(new Vector3(horizontalMovement, 0f, 0f));

            // Check if reached the distance to move to the right
            if (transform.position.x >= distanceToMove)
            {
                // Change direction
                movingRight = false;
            }
        }
        else
        {
            // Move to the left
            transform.Translate(new Vector3(-horizontalMovement, 0f, 0f));

            // Check if reached the starting position
            if (transform.position.x <= 0f)
            {
                // Change direction
                movingRight = true;
            }
        }
    }
}
