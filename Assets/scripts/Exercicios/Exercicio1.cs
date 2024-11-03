using System.Collections.Generic;
using UnityEngine;

public class Exercicio1: MonoBehaviour {
  // Criar um método que dado um número, retorne se ele é par, ímpar ou nulo

  int[] numeros = new int[4];
  string resultado;

  void Start() {
    numeros[0] = 1;
    numeros[1] = 2;
    numeros[3] = 0; // considerar 0 como nulo

    for(int i = 0; i < numeros.Length; i++) {
      if(numeros[i] != 0) {
        resultado = numeros[i] % 2 == 0 
          ? "par" 
          : "ímpar";
        print(resultado);
      } else {
        print("Nulo");
      }
    }
  }
}