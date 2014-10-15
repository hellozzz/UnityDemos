using UnityEngine;
using System.Collections;

public class BottomMoving : MonoBehaviour {
	
	public float rateMove = 1;
	public bool gameover;
	public GameController gameController;
	public GameController.State state;
	

	public  void ChangePosition ()
	{
		if (transform.position.x <= -10) {
			transform.position = new Vector3(10, transform.position.y, transform.position.z);
		}
	}

	
	void Awake(){
		GameObject gameControllerObject = GameObject.FindWithTag("GameController");
		gameController = gameControllerObject.GetComponent<GameController>();

	}
	
	// Update is called once per frame
	void Update () {
		state = gameController.state;
		if(state == GameController.State.Start) { rateMove = 2;}
		else if(state == GameController.State.Playing) rateMove = 1;
		else rateMove = 0;

		this.transform.Translate(-transform.right * rateMove * Time.deltaTime);
		ChangePosition();

	}
	

}
