using UnityEngine;

[System.Serializable]
public class FrontLinePoint : MonoBehaviour 
{
	[SerializeField] private float offset = 2;
	public Vector3 point1
	{
		get
		{
			return transform.position + transform.forward * offset;
		}
	}
	public Vector3 point2
	{
		get
		{
			return transform.position - transform.forward * offset;
		}
	}

#if UNITY_EDITOR
	private void OnDrawGizmos() 
	{
		Gizmos.color = Color.red;
		Gizmos.DrawLine(point1, point2);
		Gizmos.DrawSphere(transform.position, 0.06f);
	}
#endif
}
