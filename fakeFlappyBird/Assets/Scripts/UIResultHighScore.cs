using UnityEngine;
using System.Collections;

public class UIResultHighScore : MonoBehaviour {

	private GameController gameController;
	private UILabel label;
	
	void Awake(){
		gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
		label = transform.GetComponent<UILabel>();
		label.text = "Best : " + gameController.highScore.ToString();
	}
}
