using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreEnemyCollision : MonoBehaviour
{
	public GameObject player;
	public GameObject boss;
	public GameObject enemy1;
	public GameObject enemy2;

	void Update()
	{
		if (player != null && boss != null && enemy1 != null && enemy2 != null) {
			Physics.IgnoreCollision (player.GetComponent<Collider> (), boss.GetComponent<Collider> ());
			Physics.IgnoreCollision (player.GetComponent<Collider> (), enemy1.GetComponent<Collider> ());
			Physics.IgnoreCollision (player.GetComponent<Collider> (), enemy2.GetComponent<Collider> ());
		}
	}
}
