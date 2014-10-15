using UnityEngine;
using System.Collections;

public class UIHideShowResult : MonoBehaviour {

	private GameController gameController;
	void Awake(){
		gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
		this.gameObject.SetActive(false);
	}
	void Update(){
		if(gameController.state == GameController.State.End) 

			this.gameObject.SetActive(true);
		else
			this.gameObject.SetActive(false);
	}

}
