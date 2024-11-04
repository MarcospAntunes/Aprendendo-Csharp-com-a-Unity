using UnityEngine;


// Funciona da mesma forma que o JUMP em Assembly
public class GoTo : MonoBehaviour {
  int numeroAleatorio;
  void Start() {

    pontoInicial:
    numeroAleatorio = Random.Range(0, 11);
    
    if(numeroAleatorio >= 5) {
      print(numeroAleatorio);
      goto pontoInicial;
    } else {
      goto pontoFinal;
    }

    pontoFinal:
    print(numeroAleatorio);
    print("Numero eleito foi menor do que 5");
  }
}