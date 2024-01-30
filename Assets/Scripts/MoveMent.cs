using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MoveMent : MonoBehaviour
{
    [SerializeField]
    float speed;
    [SerializeField]
    KeyCode rightKey, leftKey;
    [SerializeField]
    Rigidbody2D rb;
    [SerializeField]

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(rightKey))
        {
            rb.transform.position = new Vector2 (speed + rb.position.x , rb.position.y);
        }
        if (Input.GetKey(leftKey))
        {
            rb.transform.position = new Vector2(-speed + rb.position.x, rb.position.y);
        }
    }
}
