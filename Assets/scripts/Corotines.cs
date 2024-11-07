using System.Collections;
using UnityEngine;

public class Rotinas: MonoBehaviour {

  private void Start() {
    StartCoroutine(rotina()); // Como chamar uma rotina.
  }
  IEnumerator rotina() {
    Debug.Log("Iniciando");

    yield return new WaitForSeconds(2); // Espera 2 segundos

    Debug.Log("Passou 2 segundos"); // Executa após 2 segundos.
    int a = 0;

    yield return new WaitForSeconds(3.5f); // Espera 3.5 segundos

    a = 20;
    Debug.Log(a);

    yield return null; // Finaliza a rotina.
  }

}