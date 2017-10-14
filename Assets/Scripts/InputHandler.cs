using InControl;
using UnityEngine;

public class InputHandler : MonoBehaviour {

	private playerMovement playerMovement;
	private playerShoot playerShoot;

	private Vector3 inputMovement = Vector3.zero;
	private Vector3 inputRotation = Vector3.zero;
	private Vector3 lookRotation = Vector3.zero;

	private float speed = 10f;


	private InputDevice inDevice;

	

	void Awake ()
	{
		playerMovement = GameObject.Find("PlayerHitBox").GetComponent<playerMovement>();
		playerShoot = GameObject.Find("PlayerHitBox").GetComponent<playerShoot>();
		
		inDevice = InputManager.ActiveDevice;
	}
	
	// Update is called once per frame
	void Update ()
	{
		inputMovement = new Vector3(InputManager.ActiveDevice.LeftStick.X, 0, InputManager.ActiveDevice.LeftStick.Y);
		playerMovement.MovePlayer(inputMovement);
		

		inputRotation = new Vector3 (InputManager.ActiveDevice.RightStick.X,0,InputManager.ActiveDevice.RightStick.Y);
		playerMovement.RotatePlayer(inputRotation);
		
		if(InputManager.ActiveDevice.RightTrigger.WasPressed || InputManager.ActiveDevice.RightBumper.WasPressed)
		{
			playerShoot.Shoot();
		}
	}

}
