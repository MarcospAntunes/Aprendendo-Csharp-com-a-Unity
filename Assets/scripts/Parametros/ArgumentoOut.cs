using UnityEngine;

public class ArgumentoOut : MonoBehaviour
{
  int numero, soma, subtracao;
  void Start(){
    numero = 20;
    soma = operacoes(20, 20, out subtracao);
    operacoes1(20, 20, out subtracao, out soma);
  }
  
  int operacoes(int a, int b, out int sub) {
    sub = a - b;
    return a + b;
  }

  void operacoes1(int a, int b, out int sub, out int soma) {
    sub = a - b;
    soma = a + b;
  }
}
