using UnityEngine;
using System.Collections;

public class PipeMoving : MonoBehaviour {

	private float pipeMovRate = 0;
	private BottomMoving bottomMov;
	private Player player;
	public GameController gameController;
	public GameController.State state;
	private float rateMove = 1;


	void Awake(){
		GameObject gameControllerObject = GameObject.FindWithTag("GameController");
		gameController = gameControllerObject.GetComponent<GameController>();

	}

	void Start(){
		ChangChildPipeGap();
	}

	void Update () {
		state = gameController.state;
		if(state == GameController.State.Playing){
			this.transform.Translate(-transform.right * rateMove * Time.deltaTime);
			ChangePosition();

		}
	}

	public void ChangePosition ()
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
