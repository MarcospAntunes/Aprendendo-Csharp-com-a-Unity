using UnityEngine;

public class Save: MonoBehaviour {
  int count;
  int a;
  bool b;
  void Start() {
    count = PlayerPrefs.GetInt("count");
    count += 1;

    PlayerPrefs.SetInt("count", count); // Salva a variável na chave passada.

    PlayerPrefs.Save(); // Salva tudo.

    print(PlayerPrefs.HasKey("count")); // Retorna true se a chave já estiver sendo utilizada.

    PlayerPrefs.DeleteKey("count"); // Deleta a chave passada
    PlayerPrefs.DeleteAll(); // Deleta todas as chaves

    b = PlayerPrefs.GetInt("a") != 0;
  }

  void Update() {
    if(Input.GetMouseButtonDown(1) == true) {
      a = 1;
      PlayerPrefs.SetInt("a", a);
      PlayerPrefs.Save();
    };
    if(Input.GetMouseButtonDown(0) == true) {
      a = 0;
      PlayerPrefs.SetInt("a", a);
      PlayerPrefs.Save();
    };      
  }
}
