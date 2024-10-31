using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class variaveis: MonoBehaviour {
  int vidaPlayer = 10 , atackEnemy = 5;
  float jumprForce = 5.5f;
  bool mortePlayer = false;
  string nomePlayer = "Marquitos";

  void Start() {
    // Esta função executa todas as instruções apenas uma vez no primeiro frame do jogo sem parar

    ;

    print(vidaPlayer);
    nomePlayer = "Marcos";
    string nomeEnemy = "Darth Vader";
  }

  void Update() { 
    // Esta função executa todas as instruções durante a execução do jogo sem parar
    nomePlayer = "Fernanda";
  }
}
