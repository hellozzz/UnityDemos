using UnityEngine;
using System.Collections;

public class UIHideShowStart : MonoBehaviour {

	private GameController gameController;
	void Awake(){
		gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
	}
	void Update(){
		if(gameController.state == GameController.State.Playing) 
			this.gameObject.SetActive(false);
		else if(gameController.state == GameController.State.Start) 
			this.gameObject.SetActive(true);
	}

}
