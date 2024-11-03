using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Operadores: MonoBehaviour {
  /*

    OPERADORES RELACIONAIS

    == (igual)
    != (diferente)
    > (maior que)
    < (menor que)
    >= (maior ou igual)
    <= (menor ou igual)

  */

  int numero1 = 10, numero2 = 20;
  string nome1 = "Marcos", nome2 = "marcos";
  bool win = true, lose = false;

  void Start() {
    print(numero1 == numero2); // false
    print(numero1 != numero2); // true
    print(numero1 < numero2); // true
    print(numero1 <= numero2); // true
    print(numero1 > numero2); //false 
    print(numero1 >= numero2); // false
    print(nome1 == nome2); // false
    print(win == lose); // false
}
  void Update() {
  }
}