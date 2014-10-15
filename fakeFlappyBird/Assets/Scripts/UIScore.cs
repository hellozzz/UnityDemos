using UnityEngine;
using System.Collections;

public class UIScore : MonoBehaviour {

	private GameController gameController;
	private UILabel label;

	void Awake(){
		gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
		label = transform.GetComponent<UILabel>();
	}
	void Update(){
		if(gameController.state == GameController.State.Playing)
			label.text = gameController.score.ToString();
		else
			label.text = "";
	}

}
