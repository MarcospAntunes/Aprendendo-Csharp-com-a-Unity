using UnityEngine;

public class OperadoresLogicos: MonoBehaviour {

  int numero1 = 10, numero2 = 20;
  string resultado;
  string humor;
  bool pizza, refrigerante;
  void Start() {
    resultado = !(numero1 > numero2) ? "sim" : "não"; // "sim"
    Debug.Log(resultado);
    
    pizza = true;
    refrigerante = false;
    humor = 
      (pizza == true) && ( refrigerante == true) 
        ? "feliz" 
        : "triste";
    Debug.Log(humor);

    humor = 
      (pizza == true) || ( refrigerante == true) 
        ? "feliz" 
        : "triste";
    Debug.Log(humor);
  }

  void Update() {}
}