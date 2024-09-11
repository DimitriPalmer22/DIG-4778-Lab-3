using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float speed = 1;

    private GameObject _target;
    
    // Start is called before the first frame update
    void Start()
    {
        // Find the target object
        _target = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        // Look at the target
        transform.up = (_target.transform.position - transform.position);
    }
}
