using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;


public class EnemyFollow : MonoBehaviour {

void OnTriggerEnter(Collider other)
	{
		AICharacterControl enemyscript = other.gameObject.GetComponent<AICharacterControl>();

		if (enemyscript != null){
			enemyscript.InRadius = true;
		}
	}

	void OnTriggerExit(Collider other)
		{
			AICharacterControl enemyscript = other.gameObject.GetComponent<AICharacterControl>();

			if (enemyscript != null){
				enemyscript.InRadius = false;
			}
		}
}
