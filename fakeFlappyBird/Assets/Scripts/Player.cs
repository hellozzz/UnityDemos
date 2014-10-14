using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float rateForce = 1;
	public int score = 0;
	public bool gameover = false;
	
	// Update is called once per frame
	void Update () {
		if(!gameover && Input.GetMouseButtonDown(0)) {
			print(Time.time);
			rigidbody.AddForce(Vector3.up * rateForce);
		}
	}

	void OnCollisionEnter(Collision other){
		if(other.gameObject.tag == "pipe") {
			gameover = true;
			print ("game over");
		}
	}

	void OnTriggerExit(Collider other) {
		if(other.gameObject.tag == "gap") {
			print (++score);
		}
	}

	void OnGUI(){
		if(GUI.Button(new Rect(20f,20f,60f,30f), "Restart")) 
		   Application.LoadLevel(0);
	}

}
