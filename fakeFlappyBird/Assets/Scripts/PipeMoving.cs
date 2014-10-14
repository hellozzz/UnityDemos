using UnityEngine;
using System.Collections;

public class PipeMoving : Moving {

	void Start(){
		ChangChildPipeGap();
	}

	public  override void ChangePosition ()
	{
		if (transform.position.x <= -25) {
			transform.position = new Vector3(-5, transform.position.y, transform.position.z);
			ChangChildPipeGap();
		}
	}

	void ChangChildPipeGap(){
		foreach (Transform child in gameObject.transform){
			child.transform.position = new Vector3(child.transform.position.x, (Random.Range(-1.6f, 0.8f)),child.transform.position.z);
		}
	}
}
