using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public int highScore ;
	private GameObject player;
	public int score = 0;
	public GameObject UIResult;
	public enum State{
		Start,
		Playing,
		End
	}
	public State state;

	void Awake(){
		player = GameObject.Find("Player");
		UIResult = GameObject.Find("UI Root").transform.FindChild("Result").gameObject;
		highScore = PlayerPrefs.GetInt("highScore",0);
	}

	void Update(){
		if(state == State.End)
			EndGame();
	}

	public void AddScore(){
		score += 1;
	}
			
	public void StartGame(){
		state = State.Playing;
		player.rigidbody.useGravity = true;
	}

	public void RestartGame(){
		Application.LoadLevel(0);
	}
	public void EndGame(){
		if(score > highScore) {
			highScore = score;
			PlayerPrefs.SetInt("highScore", highScore);
		}
		UIResult.SetActive(true);
	}

}
