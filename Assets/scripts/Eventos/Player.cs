using UnityEngine;

public class Player: MonoBehaviour {

  private void Start() {
    Vilao.onEnemyDied += Comemorar;
  }
  private void Comemorar() {
    Debug.Log("Comemorando Derrota do Vião");
  }
}