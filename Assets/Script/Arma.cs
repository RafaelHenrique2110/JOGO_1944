using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
   public GameObject municao;
   public Transform mira;
   public KeyCode KeyShoot;
   public int tipoTiro;

    void Start()
    {
        
    }

 
    void Update()
    {
        if (Input.GetKeyDown(KeyShoot)){
            Atirar();

        }      
    }

    void Atirar(){
        for (int i = -tipoTiro; i <= tipoTiro; i++){
            Vector3 P = new Vector3(tipoTiro * 0.25f, 0, 0);
            Instantiate(municao, mira.position + P, mira.rotation);
        }   
    }
}
