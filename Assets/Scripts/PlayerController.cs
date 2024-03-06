using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(UnityEngine.AI.NavMeshAgent))]
public class PlayerController : MonoBehaviour
{
	private Camera cam;
	private UnityEngine.AI.NavMeshAgent agent;
	private Animator m_Animator;
	// Start is called before the first frame update
	void Start() {
		cam = Camera.main;
		agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
		m_Animator = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update() {
		//if (Input.GetMouseButtonDown(1)) {
		//	Ray ray = cam.ScreenPointToRay(Input.mousePosition);
		//	RaycastHit hit;

		//	if (Physics.Raycast(ray, out hit, 100)) {
		//		agent.SetDestination(hit.point);
		//	}
		//}
		//update_Locomotion();

		
	}

	private void update_Locomotion() {
		float factor = agent.velocity.magnitude / 10;
		m_Animator.SetFloat("Speed", factor, 0.1f, Time.deltaTime);
		if(Input.GetKey(KeyCode.LeftShift) ) {
			agent.speed = 20;
		} else {
			agent.speed = 10;
		}
	}
}
