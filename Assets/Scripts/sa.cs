using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sa : MonoBehaviour {
	public GameObject parent3;
	public GameObject parent2;


	public void OnClick (int number){

		switch (number) {

		case 0:
			Debug.Log ("戻る");
			parent3.SetActive (true);
			parent2.SetActive (false);
			break;
		default:
			break;
	}
}
}