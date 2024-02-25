using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class municao : MonoBehaviour
{
    public float speed;

    void Start()
    {
        Destroy(gameObject, 1.0f);  
    }

     
    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);  
    }

    
}
