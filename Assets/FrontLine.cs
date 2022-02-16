using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[ExecuteInEditMode]
public class FrontLine : MonoBehaviour 
{
	public LineRenderer line1;
	public LineRenderer line2;
	public List<FrontLinePoint> points;
	
	// Update is called once per frame (60 times per second)
	private void Update () 
	{
		if(points == null)
			return;

		UpdatePoints ();
	}
	// Update is called 50 times per second
	private void UpdatePoints () 
	{
		line1.positionCount = points.Count;
		line2.positionCount = points.Count;
		for (int i = 0; i < points.Count; i++)
		{
			line1.SetPosition(i, points[i].point1);

			int p = (points.Count - 1) - i;
			line2.SetPosition(i, points[p].point2);
		}
		// for (int i = points.Count-1; i >= 0; i--)
		// {
			
		// }
	}
}
