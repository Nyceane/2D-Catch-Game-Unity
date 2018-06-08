using UnityEngine;
using System.Collections;

public class HatController : MonoBehaviour {

	public Camera cam;

    private Rigidbody2D hat;
	private Renderer hatRend;
	private float maxWidth;
	private bool canControl; 

	// Use this for initialization
	void Start () {
		if (cam == null) {
			cam = Camera.main;
		}
		canControl = false;
		hat = GetComponent<Rigidbody2D> ();
		hatRend = GetComponent<Renderer> ();
	
		Vector3 uppercorner = new Vector3 (Screen.width, Screen.height, 0.0f);
		Vector3 targetWidth = cam.ScreenToWorldPoint (uppercorner);
		float hatWidth = hatRend.bounds.extents.x;
		maxWidth = targetWidth.x-(hatWidth);
	}
	
	// FixedUpdate is called once per physics timestep.
	void FixedUpdate () {
		if (canControl) {
			Vector3 rawPosition = cam.ScreenToWorldPoint (Input.mousePosition);
			float targetWidth = Mathf.Clamp (rawPosition.x, -maxWidth, maxWidth);
			Vector3 targetPosition = new Vector3 (targetWidth, 0.0f, 0.0f);
			hat.MovePosition (targetPosition);
		}
	}

	public void ToggleControl(bool toggle)
	{
		canControl = toggle;
	}
}
