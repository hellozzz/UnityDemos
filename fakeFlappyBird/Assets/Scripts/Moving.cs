using UnityEngine;
using System.Collections;

public class Moving : MonoBehaviour {

	public float rateMove = 1;
	public bool gameover;
	private Player player;

	void Awake(){
		player = GameObject.Find("Player").GetComponent<Player>();
	}

	// Update is called once per frame
	void Update () {
		gameover = player.gameover;
		if(!gameover){
			this.transform.Translate(-transform.right * rateMove * Time.deltaTime);
			ChangePosition();
		}
	}

	public virtual void ChangePosition(){}
}
