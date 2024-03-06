using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class CameraController : MonoBehaviour {
	public Transform target;

	public Vector3 offset;
	public float zoomSpeed = 4f;
	public float minZoom = 5f;
	public float maxZoom = 15f;

	public float pitch = 2f;

	public float rollSpeed = 100f;

	public float currentZoom = 10f;
	public float currentRoll = 0f;

	// Start is called before the first frame update
	void Start() {

	}

	// Update is called once per frame
	void Update() {
		currentZoom -= Input.GetAxis("Mouse ScrollWheel") * zoomSpeed;
		currentZoom = Mathf.Clamp(currentZoom, minZoom, maxZoom);
		currentRoll -= Input.GetAxis("Horizontal") * rollSpeed * Time.deltaTime;
	}

	private void LateUpdate() {
		transform.position = (target.position - offset * currentZoom);
		transform.LookAt(target.position + Vector3.up * pitch);

		transform.RotateAround(target.position, Vector3.up, currentRoll);
	}
}
