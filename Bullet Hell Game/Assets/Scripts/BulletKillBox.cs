using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletKillBox : MonoBehaviour 
{

	void OnTriggerExit(Collider other)
	{
		Destroy(other.gameObject.transform.parent.gameObject);
	}
}
