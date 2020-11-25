using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
using Repository;
namespace Audio
{
public class AudioSettings : MonoBehaviour
{
	public Button myButton;



	public void Mute (){
		if (AudioListener.volume == 0) {

			AudioListener.volume = 1;
			GameDataRep.SoundUpdate (1);
		}
		else {

			AudioListener.volume = 0;
			GameDataRep.SoundUpdate (0);
		}
	}


}
}