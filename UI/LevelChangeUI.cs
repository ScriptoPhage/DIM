using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Repository;

namespace UI
{
public class LevelChangeUI : MonoBehaviour {

	public int sceneToLoad;
	public int sceneToReturn;
	public GameObject LevelCompleteUI;
	private void Start()
	{
		LevelCompleteUI.SetActive(false);
	}
	private void OnTriggerEnter(Collider other)
	{
		if (other.name == "Player") 
		{
			LevelCompleteUI.SetActive(true);
			GameDataRep.LevelUpdate ( GameDataRep.LevelPotence () + 1);
			if (GameDataRep.LevelPotence () >= 4) 
			{
				GameDataRep.LevelUpdate (0);
			}
			Time.timeScale = 0f;

			//SceneManager.LoadScene(sceneToLoad);
		}
	}
	public void Restart()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene(sceneToReturn);
	}
	public void LoadMenu()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene(0);
	}


	public void LoadLevel()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene(sceneToLoad);
	}
}
}