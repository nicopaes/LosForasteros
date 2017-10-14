using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

	public int totalHealth;
	[SerializeField]
	private int currentHealth;

	private void OnEnable()
	{
		currentHealth = totalHealth;
	}
	public void TakeDamage(int damage)
	{
		currentHealth -= damage;
	}
}
