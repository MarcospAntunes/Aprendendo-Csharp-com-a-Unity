using UnityEngine;

public class InvocarRepetidamente: MonoBehaviour {

  private void Start() {
    InvokeRepeating("Alou", 0, 2); // Metódo que será chamado pela primeira vez após 0 segundos e irá ficar sendo chamado de 2 em 2 segundos
  }

  private void Update() {
    if(Input.GetMouseButton(0)) {
      CancelInvoke();
    }
  }
  private void Alou() {
    Debug.Log("Alou");
  }
}