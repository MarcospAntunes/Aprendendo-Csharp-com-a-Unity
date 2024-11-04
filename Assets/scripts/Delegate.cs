using UnityEngine;

public class Delegate: MonoBehaviour {

  delegate void exemploDel(int x);

  exemploDel variavelDel;
  void Start() {
    variavelDel = ataque;
    variavelDel += defesa;

    variavelDel -= ataque;

    variavelDel(); // Executa todos métodos associados a este delegate
  }

  void ataque(int x) {
    // IMPLEMENTACAO
  }

  void pulo(exemploDel metodo) {
    // IMPLEMENTACAO
  }

  void defesa() {
    // IMPLEMENTACAO
  }
}