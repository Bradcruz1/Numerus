using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy1: MonoBehaviour
{
	public int PlayerDamageGiven = 2;
	GameObject SubEnemy;
	EnemyHealth1 enemyHealth;

	void Awake()
	{
		SubEnemy = GameObject.FindGameObjectWithTag ("SubEnemy 1");
		if (SubEnemy != null) {
			enemyHealth = SubEnemy.GetComponent<EnemyHealth1> ();
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject == SubEnemy)
		{
			enemyHealth.TakeDamage (PlayerDamageGiven);
			Destroy (gameObject);
		}
	}
}
