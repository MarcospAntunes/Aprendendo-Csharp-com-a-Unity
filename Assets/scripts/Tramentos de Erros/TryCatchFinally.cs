using UnityEngine;

public class TryCatchFinally: MonoBehaviour {
  public int n1, n2, resultado;

  void Start() {
    try {
      resultado = n1 / n2;
      Debug.Log(resultado); // Esta linha não será executada caso a linha anterior dê erro.

    } catch (UnityException error) {
      Debug.Log("Ligando"); // Não será executado porque condicionamos o catch apenas a imprimir o erro por conta do " UnityException error ".

      Debug.Log(error);

      Debug.Log("alou"); // Não será executado porque condicionamos o catch apenas a imprimir o erro por conta do " UnityException error ".

    } finally {
      Debug.Log("Este erro não vai me parar");
    }
  }
  void Update() {

  }
}