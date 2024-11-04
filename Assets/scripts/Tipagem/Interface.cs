using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Interface: MonoBehaviour {}

public interface IInteracoes<T> {
  void Interacao(float T);
}

public class Door: MonoBehaviour, IInteracoes<float> {
  public void Interacao(float game) {
    // Implementação do código
  }
}