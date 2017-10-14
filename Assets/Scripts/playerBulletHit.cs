using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBulletHit : bulletHit
{
	public int bulletDamage;
	public override void Hit()
	{
		GetComponent<Health>().TakeDamage(bulletDamage);
		Debug.Log("TakeDamage");
	}
}
