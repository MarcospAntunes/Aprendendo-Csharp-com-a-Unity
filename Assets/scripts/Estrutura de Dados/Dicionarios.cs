using System.Collections.Generic;
using UnityEngine;

public class Dicionario: MonoBehaviour {  
  Dictionary<string, string> viloes = new Dictionary<string, string>();

  void Start() {
    viloes.Add("ceifador", "ceifador é o vilão da primeira fase"+ 
    "altura:180cm;" +
    "força:200;" +
    "velocidade:20;"
    );
    
    viloes.Add("exterminadorDoTeuFuro", "Exterminador do Teu Furo é o vilão da segunda fase" +
    "altura:20cm;" +
    "força:500;" +
    "velocidade:50;"
    );

    viloes.Remove("ceifador");
    
    print(viloes["exterminadorDoTeuFuro"]);

    int tamanhoDicionario = viloes.Count;
  }
}