using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// Struct é útil para quando o item não possui uma interação complexa, por exemplo, um papel com texto.

public class Estruturas: MonoBehaviour {
  Moto Falcon = new Moto(10.5f, "Alou");
  void Start() {
    Falcon.potencia = 10.5f;
    Falcon.marca = "Perguntei?";
    Falcon.LigarMoto();
  }
}

public struct Moto {
  public float potencia;
  public string marca;

  public Moto(float potencia, string marca) {
    this.potencia = potencia;
    this.marca = marca;
  }

  public void LigarMoto() {
    /* 
      IMPLEMENTAÇÃO
    */
  }
}