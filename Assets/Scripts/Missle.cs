using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UIElements;

public class Missle : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D rb;

    [SerializeField]
    float speed;

    [SerializeField]
    float speed_multiplier = 1f;
 


    void Update()
    {
        speed += Time.deltaTime * speed_multiplier;
        rb.velocity = transform.up * (Mathf.Min(20,speed));

    }
}
