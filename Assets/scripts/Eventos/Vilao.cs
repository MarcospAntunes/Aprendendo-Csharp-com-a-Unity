using UnityEngine;

public class Vilao: MonoBehaviour {
  public delegate void EnemyDeath();
  public static event EnemyDeath onEnemyDied;

  public int enemyLife = 10;
  
  void Update() {
    if(enemyLife == 0) {
      if(onEnemyDied != null) {
        onEnemyDied();
      }
    }
  }
}