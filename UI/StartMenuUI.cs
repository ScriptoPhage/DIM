using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using Repository;

namespace UI
{
public class StartMenuUI : MonoBehaviour {
	public AudioSource menu;
	public AudioSource click;
	public AudioSource click1;
	public AudioSource click2;
	// Use this for initialization
	void Start () {
		//PlayerPrefs.SetInt ("LevelPassed",0);
		if (GameDataRep.SoundState ()==1) {
			menu.Play ();
		}
	}

	// Update is called once per frame

	public void play()
	{
		if (GameDataRep.SoundState ()==1) {
			click.Play ();
		}
		if (GameDataRep.LevelPotence () > 1) {
			
			SceneManager.LoadScene (GameDataRep.LevelPotence () + 1);


		}
		 
		else {
			SceneManager.LoadScene (5);
		}
		//done
	}
	public void Store()
	{
		if (GameDataRep.SoundState ()==1) {
			click1.Play ();
		}
		SceneManager.LoadScene (1);
	}

	public void Settings()
	{
		if (GameDataRep.SoundState () == 1) {
			click1.Play ();
		}
		SceneManager.LoadScene (7);
	}

	public void Level()
	{
		if(GameDataRep.SoundState ()==1)
		{
		click2.Play();
		}
		SceneManager.LoadScene (2);
	}

	public void Quit()
	{
		
		Application.Quit ();
	}
	public void returntoHome()
	{
		SceneManager.LoadScene (0);
	}


}
}