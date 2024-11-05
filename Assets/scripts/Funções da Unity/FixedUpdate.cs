using UnityEngine;

public class FixedUpdateUnity: MonoBehaviour {

  void FixedUpdate() {
    // Chamado de forma constante, não dependendo da quantidade de frame
    // Foi criado para as físicas do jogo (movimentação, força, gravidade...)
  }
  
  void Update() {
    // Chamado a cada frame
  }
}