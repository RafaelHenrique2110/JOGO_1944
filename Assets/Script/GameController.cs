using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
  public static GameController instance;
  public int pontos;
  public Text textPontos;
  public int vidas;
  public Text textVidas;

  void Start()
  {
    instance = this;  
  }


    
  public void AddPontos(){
    pontos++;
    textPontos.text = "Pontos: " + pontos;
  }

  public void AddVidas(){
    vidas--;
    textVidas.text = "Vidas: " + pontos;

   
  }
  
  
  
  

}
