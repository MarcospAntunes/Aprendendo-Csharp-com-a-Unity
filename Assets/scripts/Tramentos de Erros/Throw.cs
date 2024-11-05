using System;
using UnityEngine;

public class Throw: MonoBehaviour {
  public int n1;

  void Start() {
    if(n1 < 0) {
      throw new Exception("O número fornecido foi negativo");
    } else {
      
    }
  }
  void Update() {

  }
}