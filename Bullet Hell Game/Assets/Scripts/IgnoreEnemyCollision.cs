using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreEnemyCollision : MonoBehaviour
{
	public GameObject player;
	public GameObject enemy;

	void Update()
	{
		if (player != null && enemy != null) {
			Physics.IgnoreCollision (player.GetComponent<Collider> (), enemy.GetComponent<Collider> ());
		}
	}
}
