using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{
    public float speed;
    public float amplitude;

    void Start()
    {
        
    }

   
    void Update()
    {
      Vector3 dir = new Vector3(Mathf.Sin(transform.position.z ) * amplitude, 0, -1);
      transform.position += dir * speed * Time.deltaTime;  
    }

  void OnCollisionEnter(Collision other){
        if (other.gameObject.CompareTag("municao")){
          Destroy(gameObject);
          Destroy(other.gameObject);
          GameController.instance.AddPontos();    
      
        }
    }
}
