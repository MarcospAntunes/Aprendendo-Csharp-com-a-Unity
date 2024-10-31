using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class variaveis: MonoBehaviour {

  int numero1, numero2;

  void Start() {
    // Esta função executa todas as instruções apenas uma vez no primeiro frame do jogo sem parar

    numero1 = 10;
    numero2 = 20;
    Soma();
    Multiplicacao(numero1, numero2);
  }

  void Update() { 
    // Esta função executa todas as instruções durante a execução do jogo sem parar
  }

  void Soma() {
    int resultado;
    resultado = numero1 + numero2;

    Debug.Log(resultado); // Mesma coisa que o "print". Porém, o print só pode ser utilizado em classes do tipo MonoBehaviour, já o "Debug.Log" pode ser usado em qualquer lugar.

  }

  void Multiplicacao(int num1, int num2) {
    int resultado = num1 * num2;

    Debug.Log(resultado);
  }


}
