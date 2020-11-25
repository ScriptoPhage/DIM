using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


namespace Repository
{
public class GameDataRep {
    
	public static string[] gameobjectTags = {"Player","Box","Box 2"};
		public static GameObject[] gameobjects = { GameObject.Find ("Player")};
	public static string LevelPassed = "LevelPassed";
	public static string itemNo = "itemNo";
	public static string SoundStatus = "SoundStatus";
	public static Color color ;

	public static void LevelUpdate(int i)
	{
		PlayerPrefs.SetInt (LevelPassed, i);
	}

	public static int LevelPotence()
	{
		return PlayerPrefs.GetInt (LevelPassed);
	}

	public static void ItemUpdate(int i)
	{
		PlayerPrefs.SetInt (itemNo, i);
	}
	public static int ItemAvailable()
	{
		return PlayerPrefs.GetInt (itemNo);
	}
	public static void SoundUpdate(int i)
	{
		PlayerPrefs.SetInt (SoundStatus, i);
	}
	public static int SoundState()
	{
		return PlayerPrefs.GetInt (SoundStatus);
	}



}
}