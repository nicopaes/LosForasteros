using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{ 
	public Transform playerPool;

	private int playersInGame;

	private Color[] playerColors = { Color.red, Color.blue, Color.green, Color.yellow };

	public void SpawnPlayers(int qtPlayer)
	{
		for (int i = 0; i < playerPool.childCount; i++)
		{
			if(!playerPool.GetChild(i).gameObject.activeSelf)
			{
				playersInGame++;
				playerPool.GetChild(i).gameObject.SetActive(true);
				playerPool.GetChild(i).GetComponent<PlayerInfo>().SetInfo(playersInGame, playerColors[playersInGame]);
				
				if (playersInGame == qtPlayer)
					break;
			}
		}	
	}
}
