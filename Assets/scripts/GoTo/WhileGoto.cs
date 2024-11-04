using UnityEngine;

// Mais recomendado que goto.
public class WhileGoto : MonoBehaviour {
  int numeroAleatorio, x=10, y;
  void Start() {
    while(numeroAleatorio >= 5){
      print(numeroAleatorio);
      numeroAleatorio = Random.Range(0, 11);
    }

    print(numeroAleatorio);
    print("Numero eleito foi menor do que 5");
  }

  // Quando usar o goto
  void caso() {
    int numeroAleatorio1 = Random.Range(0, 11);
    switch(numeroAleatorio1) {
      case 1:
        x = 20;
        y = 20;
        break;

      case 5:
        x = 30;
        goto case 7;

      case 7:
        y= x * 3;
        break;
    
      default:
        x = 0;
        y = 0;
        break;
    }
  }

}