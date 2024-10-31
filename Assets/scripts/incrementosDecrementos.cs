using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class IncrementosDecrementos: MonoBehaviour {

  int numero; // Quando uma variável do tipo int é iniciada sem valor, ela irá receber o valor 0
  float tempo;

  void Start() {
    
  }
  void Update() {
    // print(numero++); // Soma 1 na própria variável

    tempo += Time.deltaTime;
    Debug.Log(tempo);
  }
}