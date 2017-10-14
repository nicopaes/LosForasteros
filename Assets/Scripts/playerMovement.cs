using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {

	public float speed;

	[System.Serializable]
	[HideInInspector]
	public struct Octadiretion
	{
		public Vector3 vec;
		public string name;
	}
	[Space]
	public Octadiretion[] lookDirections = new Octadiretion[8];

	private CharacterController _playerCharacterController;

	private void Awake()
	{
		_playerCharacterController = GetComponent<CharacterController>();
	}

	// Update is called once per frame
	void Update () {
		
	}
	public void MovePlayer(Vector3 inputMove)
	{
		Vector3 movement;
		//movement = transform.TransformDirection(-inputMove);
		movement = inputMove;
		movement *= speed;

		_playerCharacterController.Move(movement * Time.deltaTime);
	} 
	public void RotatePlayer (Vector3 inputRotate)
	{
		Vector3 lookRotation;
		lookRotation = -translateOcta(inputRotate, 0.5f, lookDirections);
		if (lookRotation != Vector3.zero)
			transform.rotation = Quaternion.LookRotation(lookRotation);

	}
	Vector3 translateOcta(Vector3 input, float range, Octadiretion[] directions)
	{
		foreach (Octadiretion dir in directions)
		{
			if (input == Vector3.zero)
				return Vector3.zero;
			else
			{
				if (Vector3.Distance(input, dir.vec) < range)
					return dir.vec;
			}
		}
		return Vector3.zero;
	}
}
