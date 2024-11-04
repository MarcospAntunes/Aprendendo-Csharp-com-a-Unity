using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// Classe Abstrata serve apenas como referência.
public class ClasseAbstrata: MonoBehaviour {
  // " Viloes Orc = new Viloes(); " -> Não é possível fazer isso.
}

public abstract class Viloes {
  public float forca, velocidade;
  public void Violoes() {
    forca = 100;
    velocidade = 50;
  }

  abstract public void ataque();
}

public class Dracula: Viloes {
  override public void ataque() {
    forca = 1000;
  }
}