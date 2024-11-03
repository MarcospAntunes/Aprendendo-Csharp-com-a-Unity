using UnityEngine;

public class Array : MonoBehaviour {

  int[] numeros = {10, 20, 30}; // Aqui já muda um pouco do JavaScript.
  int[] numeros2;
  string[] nomes; // Preciso dizer o tamano do Array antes de associar algum valor.

  void Start() {
    Debug.Log(numeros[0]);
    Debug.Log(numeros[1]);
    Debug.Log(numeros[2]);

    numeros[1] = 15;
    Debug.Log(numeros[1]);

    nomes = new string[5];
    nomes[0] = "Marcos";
    Debug.Log(nomes[0]);
    Debug.Log(nomes[2]); // -> Irá retor null

    numeros2 = new int[50];
    for(int i = 0; i < numeros2.Length; i++) {
      numeros2[i] = (i + 1) * 10;
      print(numeros2[i]); // Também poderia ser usado Debug.Log()
    }
  }
}