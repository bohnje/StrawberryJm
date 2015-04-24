using UnityEngine;
using System.Collections;

public class Lock : MonoBehaviour {

	private bool locked;

	// Use this for initialization
	void Start () {
		locked = true;
	}
	
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Key")
		{
			Object.Destroy(col.gameObject);
			locked = false;
		}
	}

	public bool IsLocked()
	{
		return locked;
	}
}
