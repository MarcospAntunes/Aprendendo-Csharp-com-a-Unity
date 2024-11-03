using System.Collections.Generic;
using UnityEngine;

public class Listas: MonoBehaviour {

  List<int> numeros = new List<int>();
  void Start() {
    numeros.Add(2); // Adiciona um elemento
    numeros.Add(4); // Adiciona um elemento
    numeros.Add(4); // Adiciona um elemento
    numeros.Add(6); // Adiciona um elemento

    numeros.Remove(2); // Remove um elemento

    numeros.RemoveAt(3); // Remove um elemento no índice informado

    numeros.Sort(); // Ordena a Lista em forma crescente

    numeros.RemoveRange(0, 2); // Remove 2 elementos apartir do índice 0

    numeros.IndexOf(2); // Retorna o índice do elemento

    numeros.LastIndexOf(4); // Retorna o índice do último elemento com o valor informado

    int tamanhoLista = numeros.Count; // Retorna o amanho da lista
    
    numeros.Clear(); // Remove todos os elementos
  }
}