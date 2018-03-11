using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMovement : MonoBehaviour 
{
	public Transform[] WayPoints;
	public float Speed;
	public int currentWayPoint;
	public bool Patrol = true;
	public Vector3 Target;
	public Vector3 MoveDirection;
	public Vector3 Velocity;

	void Update ()
	{
		if(currentWayPoint < WayPoints.Length)
		{
			Target = WayPoints[currentWayPoint].position;
			MoveDirection = Target - transform.position;
			Velocity = GetComponent<Rigidbody>().velocity;

			if(MoveDirection.magnitude < 1)
			{
				currentWayPoint++;
			} else
			{
				Velocity = MoveDirection.normalized * Speed;
			}
		} else
		{
			if(Patrol)
			{
				currentWayPoint = 0;
			} else
			{
				Velocity = Vector3.zero;
			}
		}

		GetComponent<Rigidbody>().velocity = Velocity;
		{
			transform.Rotate (new Vector3 (0, 0, 0) * Time.deltaTime);
		}
	}
}
