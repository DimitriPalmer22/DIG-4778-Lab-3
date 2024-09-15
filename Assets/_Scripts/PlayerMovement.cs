using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Start()
    {
        StartCoroutine(CheckForInput());
    }

    IEnumerator CheckForInput()
    {
        while (true)
        {
            Vector3 newPosition = transform.position;

            // Check for left and right inputs
            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
            {
                newPosition.x -= moveSpeed * Time.deltaTime;
            }
            else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
            {
                newPosition.x += moveSpeed * Time.deltaTime;
            }

            // Apply the new position
            transform.position = newPosition;

            yield return null;
        }
    }
}
