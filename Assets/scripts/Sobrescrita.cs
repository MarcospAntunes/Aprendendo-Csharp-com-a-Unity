

public class Sobrescrita {

}

public class Monstros {
  public virtual void Ataque() {
    /*
      
      Implementação do método

    */
  }
}

public class Frankesntein: Monstros{
  public override void Ataque()
  {
    base.Ataque();
    /*
      
      Tirusbango à mais

    */
  }
}

public class Matematica {
  public virtual int Soma(int a, int b) {
    return a + b;
  }
}

public class Fisica: Matematica {
  public override int Soma(int a, int b) {
    int resultado = base.Soma(a, b);
    int resultadoFinal = resultado + 10;
    return resultadoFinal;
  }
}