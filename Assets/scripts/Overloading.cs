using UnityEngine;

public class Overloading: MonoBehaviour {
  calculadora calc = new calculadora();
  int resultadoInt;
  int resultadoInt1;
  float resultadoFloat;
  void Start() {
    resultadoInt = calc.soma(2, 4);
    resultadoFloat = calc.soma(2.5f, 3.1f);
    resultadoInt1 = calc.soma(1,2,3);
  }
}

public class calculadora {
  public int soma(int a, int b) {
    return a + b;
  }

  public int soma(int a, int b, int c) {
    return a + b + c;
  }

  public float soma(float a, float b) {
    return a + b;
  }
}