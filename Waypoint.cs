
using UnityEngine;


public class Waypoint : MonoBehaviour {




	public static Transform[] points; //enter all the waypoints you want

	void Awake ()
	{ // on awake
		points = new Transform[transform.childCount]; //set points equal to the amount of points are in the array
		for (int i = 0; i < points.Length; i++)
		{//per one that there is in the array
			points[i] = transform.GetChild(i); //get the child of the transform
		}
	}

}
