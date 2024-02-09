using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField]
    GameObject ms;

    [SerializeField]
    float spawnrate = 2f;

    [SerializeField]
    float spawn_subs = 0.1f;

    [SerializeField]
    float spawnrate_limit = 0.3f;


    void Start()
    {
        StartCoroutine(spawn_timer());
    }
    void Update()
    {
        spawnrate -= Time.deltaTime * spawn_subs;
    }

    IEnumerator spawn_timer()
    {
        yield return new WaitForSeconds(Mathf.Max(spawnrate_limit, spawnrate));
        Destroy(Instantiate(ms, new Vector2(Random.Range(-7.3f , 7.3f),-9.5f), Quaternion.identity) , 2f);
        StartCoroutine(spawn_timer());

    }



}
