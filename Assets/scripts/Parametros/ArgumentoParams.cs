using UnityEngine;

public class ArgumentoParams : MonoBehaviour
{
  int numero, soma, subtracao;
  void Start(){
    numero = 20;

    soma = operacoes(20, 20, out subtracao);

    operacoes1(20, 20, out subtracao, out soma);
    
    soma = SomaNumeros(20, 3, 4, 5, 6, 6, 7, 8, 89, 20);
  }
  
  int operacoes(int a, int b, out int sub) {
    sub = a - b;
    return a + b;
  }

  void operacoes1(int a, int b, out int sub, out int soma) {
    sub = a - b;
    soma = a + b;
  }

  int SomaNumeros(params int[] array) {
    int resultado = 0;

    for(int i = 0; i < array.Length; i++) {
      resultado = resultado + array[i];
    }

    return resultado;
  }
}
