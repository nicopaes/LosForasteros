using InControl;
using UnityEngine;

public class InputHandler : MonoBehaviour {

	public Transform playerPool;

	//private playerMovement playerMovement;
	private playerShoot playerShoot;

	private SpawnManager spawnManager;

	private Vector3 inputMovement = Vector3.zero;
	private Vector3 inputRotation = Vector3.zero;
		

	void Awake ()
	{
		spawnManager = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
	}
	private void Start()
	{
		spawnManager.SpawnPlayers(InputManager.Devices.Count);

		//playerMovement = GameObject.Find("PlayerHitBox").GetComponent<playerMovement>();
		//playerShoot = GameObject.Find("PlayerHitBox").GetComponent<playerShoot>();
	}
	// Update is called once per frame
	void Update ()
	{
		for (int i = 0; i < playerPool.childCount; i++)
		{
			if (playerPool.GetChild(i).gameObject.activeSelf)
			{
				playerMovement pMove = playerPool.GetChild(i).GetComponent<PlayerInfo>().thisPlayerMove;
				inputMovement = new Vector3(InputManager.Devices[i].LeftStick.X, 0, InputManager.Devices[i].LeftStick.Y);
				pMove.MovePlayer(inputMovement);

				inputRotation = new Vector3(InputManager.Devices[i].RightStick.X, 0, InputManager.Devices[i].RightStick.Y);
				pMove.RotatePlayer(inputRotation);
			}
		}
		//inputMovement = new Vector3(InputManager.ActiveDevice.LeftStick.X, 0, InputManager.ActiveDevice.LeftStick.Y);
		//playerMovement.MovePlayer(inputMovement);


		//inputRotation = new Vector3 (InputManager.ActiveDevice.RightStick.X,0,InputManager.ActiveDevice.RightStick.Y);
		//playerMovement.RotatePlayer(inputRotation);
		for (int i = 0; i < InputManager.Devices.Count; i++)
		{
			if (InputManager.Devices[i].RightTrigger.WasPressed)
			{
				if (playerPool.GetChild(i).gameObject.activeSelf)
					playerPool.GetChild(i).GetComponent<PlayerInfo>().thisPlayerShoot.Shoot();
			}
		}
	}

}
