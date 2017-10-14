using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletCollision : MonoBehaviour
{
	private void OnCollisionEnter(Collision other)
	{
		Debug.Log("Bullet Collided");
		if (other.gameObject.GetComponent<bulletHit>() != null)
			other.gameObject.GetComponent<bulletHit>().Hit();		
		Die();
	}
	void Die()
	{
		gameObject.SetActive(false);
	}
	private void OnDisable()
	{
		//Debug.Log("BulletDeactivated");
	}
}
