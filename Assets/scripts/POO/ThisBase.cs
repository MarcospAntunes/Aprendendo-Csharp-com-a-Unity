using System.Security.Cryptography.X509Certificates;

public class ThisBase {
  int numero;

  void exemplo(int numero) {
    this.numero = numero;
  }
}

public class Personagem {
  public int velocidade;
}

// A diferença entre base e this é que base chama os métodos da outra classe que estamos herdando.
public class Orc: Personagem {
  void ataque(int velocidade) {
    base.velocidade = velocidade;
  }
}