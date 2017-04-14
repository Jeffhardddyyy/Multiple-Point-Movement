using UnityEngine;

public class CameraMovement : MonoBehaviour {
	public float speed = 10f; //how fast you want the object to go

	private Transform target;
	private int wavepointIndex = 0;

	void Start ()
	{ // on start
		target = Waypoints.points[0]; // find the targets first waypoint
	}

	void Update ()
	{
		Vector3 dir = target.position - transform.position; // find the position of waypoint
		transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World); //move the way to the waypoint

		if (Vector3.Distance(transform.position, target.position) <= 0.4f)
		{//if it is close to that waypoint
			GetNextWaypoint(); //do GetNextWaypoint Function
		}
	}

	void GetNextWaypoint()
	{//when called
		if (wavepointIndex >= Waypoints.points.Length - 1)
		{//if it is close and there are no waypoints left
			Destroy(gameObject); //destroy the game object
			return; //return
		}

		wavepointIndex++; //increase the waypoint index
		target = Waypoints.points[wavepointIndex]; //mark the waypoint it's at
	}

}
