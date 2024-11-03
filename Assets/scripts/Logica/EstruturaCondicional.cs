using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EstruturaCondicional: MonoBehaviour {

  int moedas = 50, precoPersonagem = 100;
  int estadoVilao = 1;
  void Start() {
    /* -------- IF, ELSE, IF ELSE ------------ */

    if(moedas > precoPersonagem) {
      print("Posso comprar personagem.");
    } else if(moedas == precoPersonagem) {
      print("Posso comprar personagem, porém irei ficar zerado.");
    } else {
      print("Não posso comprar personagem.");
    }

    /* -------- SWITCH CASE ------------- */

    switch(estadoVilao) {
      case 1:
        print("ataca");
        break;
      
      case 2:
        print("defende");
        break;
      
      case 3:
        print("foge");
        break;
      
      default:
        print("idle");
        break;
    }
  }
  void Update() {}
  
}