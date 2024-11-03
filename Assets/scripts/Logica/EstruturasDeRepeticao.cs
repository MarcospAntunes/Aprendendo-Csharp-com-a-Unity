using UnityEngine;

// C# é bem similar ao JavaScript, me facilita muito.

public class EstruturasDeRepeticao : MonoBehaviour
{
  int y;
  int z;
  void Start() {
    for(int x = 0; x < 10; x++) {
      if(x == 2) {
        continue; // Passa o looping para a próxima etapa.
      }
      
      if(x == 5) {
        break; // Para o looping.
      }

      Debug.Log(x);

    }

    while(y < 10) {
      Debug.Log(y);
      y++; // -> essa linha garante que não ficaremos presos nesse looping
    }

    // Esse looping executa pelo menos uma vez mesmo a condição sendo falsa.
    do {
      Debug.Log(z);
      z++; // -> essa linha garante que não ficaremos presos nesse looping
    } while(z < 10);
  }
}
