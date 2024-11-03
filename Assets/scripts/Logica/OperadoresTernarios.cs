using UnityEngine;

public class OperadoresTernarios : MonoBehaviour
{
    int numero1 = 10, numero2 = 20;
    string resultado;
    void Start(){
        resultado = numero1 > numero2 ? "sim" :"não";
        Debug.Log(resultado);
    }

    void Update(){}
}
