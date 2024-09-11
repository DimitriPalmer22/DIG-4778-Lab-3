using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyScript : MonoBehaviour
{
    public float speed = 1;

    private GameObject _target;

    // Start is called before the first frame update
    void Start()
    {
        // Find the target object
        _target = GameObject.Find("Player");

        // Randomize the speed
        speed = Random.Range(5, 10);
        if (Random.Range(0, 1000) < 500)
        {
            Debug.Log($"Flipped Random");
            speed *= -1;
        }
        
        // Randomize the sprite color
        GetComponent<SpriteRenderer>().color = new Color(Random.value, Random.value, Random.value);
    }

    // Update is called once per frame
    void Update()
    {
        // Look at the target
        transform.up = (_target.transform.position - transform.position);

        transform.position += transform.right * (speed * Time.deltaTime);
    }

    private void OnDrawGizmos()
    {
        if (_target == null)
            return;

        // Set the color
        // Draw a line from the enemy to the target
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, _target.transform.position);
    }
}