using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/** 
* Clase para modelar Area Effectors. 
* 
* @author Ana Lucia Hernandez (17138).
* 
**/

public class AreaEffector : MonoBehaviour {
	public float time =0f;
	public float unactive =0;
	public GameObject areaEffector;
	
		// Use this for initialization
	void Start () {

		
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		if (time > 5)
		{
			areaEffector.SetActive(false);
			unactive += Time.deltaTime;
			if (unactive > 3)// sirve para que después de un tiempo en el que se apaguen los area effectors, se vuelvan a encender
			{
				areaEffector.SetActive(true);
				time =0;
				unactive =0;
			}
		}
	}
}
