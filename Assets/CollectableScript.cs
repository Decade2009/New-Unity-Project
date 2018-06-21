using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableScript : MonoBehaviour {
	public int points;
	HUD_Manager hudmanager;

	// Use this for initialization
	void Start () {
		hudmanager = GameObject.FindGameObjectWithTag("Player").GetComponent<HUD_Manager>();
	}

	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (0, 60, 0) * Time.deltaTime);

	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.CompareTag("Player")) {
		gameObject.SetActive(false);
		hudmanager.UpdateScore(points);

}
}
}
