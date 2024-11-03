using UnityEngine;

public class ForEach: MonoBehaviour {
  int[] numeros = {1,2,3,4,5,6,7,8,9,10};

  void Start(){

    // Também é diferente do Javascript, lembra um pouco "For in" em JavaScript
    foreach(int numero in numeros) {
      print(numero);
    }
  }
}
