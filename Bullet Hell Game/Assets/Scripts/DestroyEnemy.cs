using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy: MonoBehaviour
{
	public int PlayerDamageGiven = 2;
	GameObject SubEnemy;
	EnemyHealth enemyHealth;

	void Awake()
	{
		SubEnemy = GameObject.FindGameObjectWithTag ("SubEnemy");
		if (SubEnemy != null) {
			enemyHealth = SubEnemy.GetComponent<EnemyHealth> ();
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
