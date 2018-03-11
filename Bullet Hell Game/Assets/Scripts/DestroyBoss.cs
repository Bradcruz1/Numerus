using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBoss : MonoBehaviour
{
	public int PlayerDamageGiven = 3;
	GameObject Enemy;
	BossHealth bossHealth;

	void Awake()
	{
		Enemy = GameObject.FindGameObjectWithTag ("Enemy");
		if (Enemy != null) {
			bossHealth = Enemy.GetComponent<BossHealth> ();
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject == Enemy)
		{
			bossHealth.TakeDamage (PlayerDamageGiven);
			Destroy (gameObject);
		}
	}
}
