using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Repository;

namespace Scripts
{
public class PlayerColorScript : MonoBehaviour {
	public AudioSource power;
	public AudioSource power2;
	public  Material[] material;
	Renderer rend;
	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer> ();
		rend.enabled = true;
		rend.sharedMaterial = material [0];
	}

	private void OnCollisionEnter(Collision col)
	{
			if (col.gameObject.tag == GameDataRep.gameobjectTags[1]) {
			if (GameDataRep.SoundState () == 1) {
				power.Play ();
			}
			rend.sharedMaterial = material [1];
				GameDataRep.color = material [1].color;

			}else if(col.gameObject.tag == GameDataRep.gameobjectTags[1]) {
			if (GameDataRep.SoundState () == 1) {
				power2.Play ();
			}
			rend.sharedMaterial = material [2];
				GameDataRep.color = material [2].color;

		}
	}

	// Update is called once per frame
	void Update () {

	}
}
}