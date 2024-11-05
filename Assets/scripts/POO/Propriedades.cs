using UnityEngine;

public class Propriedades: MonoBehaviour {
  ExemploPropriedades exemplo = new ExemploPropriedades();
  
  private int x;
  void Start() {
    x = exemplo.Numero; // get
    exemplo.Numero = 5; // set
  }
}

public class ExemploPropriedades {
  private int numero = 10;
  private int numero2 = 20;
  public int Numero {
    get { return numero; }
    set { numero = value > 50 ? value : 0; }
  }

  public int Numero2 {
    get { return numero2; }
  }
}