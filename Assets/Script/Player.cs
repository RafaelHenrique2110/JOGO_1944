using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
   public float speed;
   public Arma arma;

    void Start()
    {
        
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 dir = new Vector3(h, 0, v);
        transform.position += dir * speed * Time.deltaTime;
        transform.rotation = Quaternion.Euler(0, 0, -h * 60);    
    }
    
    void OnCollisionEnter(Collision other){
        if (other.gameObject.CompareTag("PowerUp")){
            Destroy(other.gameObject);
            arma.tipoTiro++;       
            
        }

        if (other.gameObject.CompareTag("municaoInimigo")){
            Destroy(gameObject);
                   
            
        }
        
        if(other.gameObject.CompareTag("municaoInimigo")){
            GameController.instance.AddVidas();
        }
        if(other.gameObject.CompareTag("municaoInimigo")){
            SceneManager.LoadScene("Derrota");
        }
        

        

    } 
    
    

}
