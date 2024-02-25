using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public float speed;

     
    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);  
    }
}
