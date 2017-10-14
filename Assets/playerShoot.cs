using System;
using System.Collections;
using UnityEngine;

public class playerShoot : MonoBehaviour {

	public GameObject bulletPool;
	public Transform gunBarrel;
	public float cooldowntime;

	private bool _cooldownState;

	private void Awake()
	{
		bulletPool = GameObject.Find("BulletPool");
	}
	public void Shoot()
	{
		for (int i = 0; i < bulletPool.transform.childCount; i++)
		{
			var Thebullet = bulletPool.transform.GetChild(i);
			if (!Thebullet.gameObject.activeSelf && !_cooldownState)
			{
				Thebullet.GetComponent<bulletMovement>().ShootMe(gunBarrel.transform.position - gunBarrel.transform.forward, Quaternion.LookRotation(gunBarrel.transform.right));
				_cooldownState = true;
				StartCoroutine(shotCooldown());
				break;
			}
		}
	}
	IEnumerator shotCooldown()
	{
		yield return new WaitForSeconds(cooldowntime);
		_cooldownState = false;
	}
}
