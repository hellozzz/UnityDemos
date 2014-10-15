using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float rateForce = 200;
	public int score = 0;
	public bool gameover = false;
	public Texture[] birdAnim = new Texture[2];
	public AudioClip[] music = new AudioClip[3];
	private GameController gameController;
	public GameController.State state;
	public float rotationSpeed = 1	;

	public int birdFPS = 6;



	void Awake(){
		GameObject gameControllerObject = GameObject.FindWithTag("GameController");
		gameController = gameControllerObject.GetComponent<GameController>();


	}

	void Start(){
		rigidbody.useGravity = false;
	}

	// Update is called once per frame
	void Update () {
		state = gameController.state;
		print (rigidbody.velocity.y + "   " + this.transform.localEulerAngles.z);
		if(!(state == GameController.State.End)) {
		int index = (int)((Time.time * birdFPS) % 2);
		renderer.material.mainTexture = birdAnim[index];
			if(rigidbody.velocity.y > 0f) {
				transform.rotation = Quaternion.Slerp(gameObject.transform.rotation, Quaternion.Euler(0.0f, 0.0f, 60f), Time.deltaTime * 2f);
			}
				else if(rigidbody.velocity.y < 0f )
				transform.rotation = Quaternion.Slerp(gameObject.transform.rotation, Quaternion.Euler(0.0f, 0.0f, -90f), Time.deltaTime * 3f);
		}

		if(state == GameController.State.Playing && Input.GetMouseButtonDown(0)) {
			transform.rotation = Quaternion.identity;
			rigidbody.AddForce(Vector3.up * rateForce);
			audio.clip = music[0];
			audio.Play();
		}
	}

	void OnCollisionEnter(Collision other){
		if(other.gameObject.tag == "Pipe") {
			gameController.state = GameController.State.End;
			audio.clip = music[2];
			if(audio.clip == music[2] && !audio.isPlaying){
				audio.Play();
			}
		}
	}

	void OnTriggerEnter(Collider other) {
		if(other.gameObject.tag == "Gap") {
			gameController.AddScore();
			audio.clip = music[1];
			audio.Play();
		}
	}



}
