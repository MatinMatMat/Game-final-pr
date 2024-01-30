using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField]
    GameObject ms;


    [SerializeField]
    float spawnrate = 2f;
    void Start()
    {
        StartCoroutine(spawn_timer());
    }

    IEnumerator spawn_timer()
    {
        yield return new WaitForSeconds(spawnrate);
        Destroy(Instantiate(ms, new Vector2(Random.Range(-4.5f , 4.5f),-7), Quaternion.identity) , 2f);
        StartCoroutine(spawn_timer());

    }



}
