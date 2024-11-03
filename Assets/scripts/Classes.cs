using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// Classe Enemies herdando da classe MonoBehaviour
public class Enemies: MonoBehaviour {
  private GameObject Player;
  public GameObject enemyObject;
  public float speedEnemy;

  private void Main() {
    Player = GameObject.Find("Player");
  }

  public void followPlayer() {
    Main();
    enemyObject.transform.position = Vector3.MoveTowards(
      enemyObject.transform.position, 
      Player.transform.position, 
      speedEnemy * Time.deltaTime
    );
  }
}

// Classe Inimigo herdando da classe MonoBehaviour
public class Inimigo: MonoBehaviour {
  Enemies inimigo = new Enemies(); // Criando um objeto apartir de uma instância da classe Enimies

  void Start() {
    inimigo.enemyObject = gameObject;
    inimigo.speedEnemy = 2.5f;
  }

  void Update() {
    inimigo.followPlayer();
  }
}