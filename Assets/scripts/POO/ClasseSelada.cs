using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// Classe selada não pode ser herdada por outra classe. Porém, ainda conseguimos criar uma instância dela
public class ClasseSelada: MonoBehaviour {
  A obj = new A();
  void Start() {
    obj.velocidade = 10;
  }
}
sealed class A {
  public int velocidade;
}

// " class B: A {} "  -> Isso não pode acontecer.