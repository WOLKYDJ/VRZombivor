using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GunSelectorDEMO : MonoBehaviour {
	
	// Update is called once per frame
	public void M4A1 () {
		SceneManager.LoadScene ("Cage");
		PlayerPrefs.SetInt ("GunSelected", 0);

	}

	public void SMG () {
		SceneManager.LoadScene ("Cage");
		PlayerPrefs.SetInt ("GunSelected", 1);
	}

	public void HandGun () {
		SceneManager.LoadScene ("Cage");
		PlayerPrefs.SetInt ("GunSelected", 2);

	}

	public void Beretta () {

		SceneManager.LoadScene ("Cage");
		PlayerPrefs.SetInt ("GunSelected", 3);

	}
		
}
