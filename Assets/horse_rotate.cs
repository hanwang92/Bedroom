using UnityEngine;
using System.Collections;

public class horse_rotate : MonoBehaviour {
	
	public float speed = 10f;
	int animation_frame = 0;  
	
	// Joint parameters
	const float JOINT_MIN = -35.0f;
	const float JOINT_MAX =  35.0f;
	float joint_rot = 0.0f;
	int count = 0;
	
	void Update ()
	{
		// Define Variables
		GameObject horse;
		horse = GameObject.Find("horse");
		Vector3 newpos = horse.transform.position;
		newpos.y = newpos.y - 0.5f;
		
		// Update geometry
		const double joint_rot_speed = 0.03;
		double joint_rot_t = (Mathf.Sin((float)(animation_frame*joint_rot_speed)) + 1.0) / 2.0;
		joint_rot = (float)(joint_rot_t * JOINT_MIN + (1.0 - joint_rot_t) * JOINT_MAX);
		
		// Rotate about a point
		transform.RotateAround(newpos, horse.transform.right, joint_rot * Time.deltaTime);
		
		animation_frame++;
	}
}
