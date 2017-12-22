using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllerScript : MonoBehaviour {

	public GameObject imageTarget;
	public Button fireButton;
	public float speed = 250f;

	// Use this for initialization
	void Start () {
		fireButton.onClick.AddListener (OnButtonDown);	
	}

	
	// Update is called once per frame
	void Update () {
		
	}

	void OnButtonDown () {
		GameObject bullet = Instantiate(Resources.Load("bullet", typeof(GameObject))) as GameObject;
		Rigidbody rb = bullet.GetComponent<Rigidbody>();
		bullet.transform.rotation = imageTarget.transform.rotation;
		bullet.transform.position = imageTarget.transform.position;
		rb.AddForce(Camera.main.transform.forward * speed);
		bullet.GetComponent<AudioSource>().Play ();
		Destroy (bullet, 3);
	}
}
