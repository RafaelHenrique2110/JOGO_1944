using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float interval = 2.0f;
    public GameObject obj;
    public float min, max;

    void Start()
    {
      Invoke("Spawn", interval);  
    }

    void Spawn()
    {
        Vector3 P = new Vector3(Random.Range(min, max), 0, 0);
        Instantiate(obj, transform.position + P, transform. rotation);
        Invoke("Spawn", interval);     
    }
}
