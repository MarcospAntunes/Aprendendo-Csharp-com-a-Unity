using UnityEngine;

public class InputTeclado : MonoBehaviour
{
  void Update() {
    if(Input.GetKeyDown(KeyCode.W)) {
      Debug.Log("Tecla W foi pressionada");
    };
  }
}
