using UnityEngine;
using System.Collections;

public class DoorController : MonoBehaviour {

	public bool isLocked;
	private Lock attachedLock;

	// Use this for initialization
	void Start () {
		attachedLock = gameObject.GetComponent<Lock>();

		if(attachedLock != null)
		{
			isLocked = attachedLock.IsLocked();
		}
		else
		{
			isLocked = false;
		}
	}
	
	// Update is called once per frame
	void Update () {

		//check if no longer locked
		if(isLocked)
		{
			isLocked = attachedLock.IsLocked();

		}
	}
}
