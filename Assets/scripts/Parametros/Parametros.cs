using UnityEngine;

public class Parametros : MonoBehaviour
{
  int numero = 10;
    
  void Start(){
    exemplo(ref numero); // Passagem por Referência economiza muito na memória. Porém, da para modificar a informação na saída
  }
  
  void exemplo(ref int num) {
    print(num);

    num = 50; // Cuidado com isso
  }
}
