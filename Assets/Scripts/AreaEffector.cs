using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
			if (unactive > 3)
			{
				areaEffector.SetActive(true);
				time =0;
				unactive =0;
			}
		}
	}
}
