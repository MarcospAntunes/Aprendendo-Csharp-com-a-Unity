using UnityEngine;

public class InputMouse : MonoBehaviour
{
  private bool buttonLeft, buttonRight;
  void Update() {
    buttonLeft = Input.GetMouseButton(0); // Botão esquerdo. Retorna verdadeiro enquanto o botão estiver pressionado
    buttonRight = Input.GetMouseButton(1); // Botão direito. Retorna verdadeiro enquanto o botão estiver pressionado

    if(buttonLeft == true) {
      print("Pressionou botão esquerdo");
    }
    if(buttonRight == true) {
      print("Pressionou botão direito");
    }
    

    buttonLeft = Input.GetMouseButtonDown(0); // Botão esquerdo. Retorna verdadeiro quando o botão for clicado e aí volta a ser falso, mesmo que mantenha pressionado.
    buttonRight = Input.GetMouseButtonDown(1); // Botão direito. Retorna verdadeiro quando o botão for clicado e aí volta a ser falso, mesmo que mantenha pressionado.


    buttonLeft = Input.GetMouseButtonUp(0); // Botão esquerdo. Retorna verdadeiro quando o botão parar de ser clicado e aí volta a ser falso.

    buttonRight = Input.GetMouseButtonUp(1); // Botão esquerdo. Retorna verdadeiro quando o botão parar de ser clicado e aí volta a ser falso.

  }
}
