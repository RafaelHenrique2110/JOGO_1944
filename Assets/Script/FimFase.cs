using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FimFase : MonoBehaviour
{
    public string nome = "Vitoria";
     
     void OnCollisionEnter(Collision outro)
     {
       Debug.Log("colidiu!");
       SceneManager.LoadScene(nome);}
}
