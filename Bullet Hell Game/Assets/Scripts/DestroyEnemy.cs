using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
	public int PlayerDamageGiven = 10;
	GameObject Enemy;
	EnemyHealth enemyHealth;

	void Awake()
	{
		Enemy = GameObject.FindGameObjectWithTag ("Enemy");
		if (Enemy != null) {
			enemyHealth = Enemy.GetComponent<EnemyHealth> ();
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject == Enemy)
		{
			enemyHealth.TakeDamage (PlayerDamageGiven);
			Destroy (gameObject);
		}
	}
}
