using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletMovement : MonoBehaviour {

	public float speed = 15f;
	public bool shot = false;

	private Vector3 movement;
	private Vector3 startPosition;
	private Rigidbody bulletRigidbody;

	private CharacterController bulletController;
	
	void Awake () {
		bulletRigidbody = GetComponent<Rigidbody>();
	}

	private void OnEnable()
	{
		shot = true;
		Debug.Log("theObjectWasEnabled");
	}

	public void ShootMe(Vector3 position,Quaternion rotation)
	{
		gameObject.SetActive(true);
		startPosition = position;

		transform.position = position;
		transform.rotation = rotation;

		//Debug.Log("theObjectWasActivated");
	}
	
	void FixedUpdate ()
	{
		if (shot)
			MoveBullet();
		if (Vector3.Distance(startPosition, transform.position) > 80f)
			gameObject.SetActive(false);
	}
	void MoveBullet()
	{
		movement = transform.right * speed * Time.deltaTime;
		bulletRigidbody.MovePosition(transform.position + movement);
	}
}
