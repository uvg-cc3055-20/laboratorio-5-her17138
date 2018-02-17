using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/** 
 * Esta sera la clase utilizada para cambiar entre el menú principal y la escena de la nave espacial 
 * 
 * @author Ana Lucia Hernandez (17138).
 * 
 **/
public class SceneChanger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnStartGame(string nextScene)
	{
		SceneManager.LoadScene (nextScene); //cambio de escenas
	}
}
