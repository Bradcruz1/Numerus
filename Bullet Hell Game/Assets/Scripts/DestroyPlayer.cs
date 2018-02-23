using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlayer : MonoBehaviour
{
	public int EnemyDamageGiven = 10;
	GameObject Player;
	PlayerHealth playerHealth;

	void Awake()
	{
		Player = GameObject.FindGameObjectWithTag ("Player");
		if (Player != null) {
			playerHealth = Player.GetComponent<PlayerHealth> ();
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject == Player)
		{
			playerHealth.TakeDamage (EnemyDamageGiven);
			Destroy (gameObject);
		}
	}
}
