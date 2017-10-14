using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
	public playerMovement thisPlayerMove;
	public playerShoot thisPlayerShoot;
	
	[System.Serializable]
	public struct playerInfo
	{
		public int number;
		public Color color;
	}
	[Space]
	public playerInfo thisPlayerInfo;

	public void SetInfo(int number, Color color)
	{
		thisPlayerInfo.number = number;
		thisPlayerInfo.color = color;
	}
}