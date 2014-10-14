using UnityEngine;
using System.Collections;

public class BottomMoving : Moving {

	public  override void ChangePosition ()
	{
		if (transform.position.x <= -10) {
			transform.position = new Vector3(10, transform.position.y, transform.position.z);
		}
	}


}
