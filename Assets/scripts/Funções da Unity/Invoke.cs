using UnityEngine;

public class Invocar: MonoBehaviour {

  private void Start() {
    Invoke("Alou", 5.5f); // Pode bugar em larga escala, pois é muito pesado.
  }
  private void Alou() {
    Debug.Log("Alou");
  }
}