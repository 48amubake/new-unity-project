using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Controller2D))]
public class Player : MonoBehaviour {


	Controller2D controller;

	void Start() {
		controller = GetComponent<Controller2D> ();
	}

	void update () {
	
		Vector2 input = new Vector2(Input.GetAxisRaw (''horizontal''
		Velocity.y += gravity * Time.deltaTime;
	controller.Move(velocity* Time.deltaTime);
	...
}
