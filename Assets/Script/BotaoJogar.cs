using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BotaoJogar : MonoBehaviour
{
    public void BtnClick(){
       SceneManager.LoadScene("fase1");
   } 
}
