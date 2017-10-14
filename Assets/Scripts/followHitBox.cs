using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followHitBox : MonoBehaviour {

	public Transform playerHitBox;
	void Update ()
	{
		transform.position = playerHitBox.transform.position;
	}
}
