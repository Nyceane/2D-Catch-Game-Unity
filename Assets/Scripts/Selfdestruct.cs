using UnityEngine;
using System.Collections;

public class Selfdestruct : MonoBehaviour {

	public float lifetime;

	// Use this for initialization
	void Start () {
	
		Destroy (gameObject, lifetime);
	}

}
