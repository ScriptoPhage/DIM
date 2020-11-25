using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Repository;
namespace Scripts
{
public class PlayerCameraScript: MonoBehaviour {

		public Transform target = GameDataRep.gameobjects[0].GetComponent<Transform>();
	public float smoothSpeed = 0.125f;
	public Vector3 offset;

	void LateUpdate()
	{
		transform.position = target.position + offset;
	}
}

}