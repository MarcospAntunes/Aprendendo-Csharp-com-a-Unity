public class ModificadoresDeAcesso {
  public int numero; // Público
  private int numero2; // Privado
  int numero3; // Privado
  protected float numero4;

  public void setNumero2(int num) {
    numero2 = num;
  }
  public int getNumero2() {
    return numero2;
  }
}

public class Exemplo1:ModificadoresDeAcesso {
  void acessa() {
    numero = 10;
    setNumero2(2);
    numero = getNumero2();
    numero4 = 2.1f;
  }
}

public class Exemplo2 {
  ModificadoresDeAcesso objeto = new ModificadoresDeAcesso();

  void acesso() {
    objeto.numero = 10;
  }
}