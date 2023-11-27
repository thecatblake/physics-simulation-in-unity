using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject target;
    public int particleNum;
    public float spawnRadius;
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0; i < particleNum; i++) {
            Instantiate(target, transform.position + Random.insideUnitSphere * spawnRadius, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
