using UnityEngine;
using System.Collections;

public class horse_rotate : MonoBehaviour {
	
	public float speed = 10f;
	int animation_frame = 0;  
	
	// Joint parameters
	const float JOINT_MIN = -30.0f;
	const float JOINT_MAX =  30.0f;
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

        if (joint_rot == 30.0f)
        {

            transform.rotation = Quaternion.Euler(293.9684f, 121.6302f, 359.6671f);
        }
        else if(joint_rot == -30.0f)
        {
            //horse.transform.position = new Vector3(transform.position.x, 0.5417913f, transform.position.z);

        }
        else
        {
            // Rotate about a point
            transform.RotateAround(newpos, horse.transform.right, joint_rot * Time.deltaTime);
        }

        horse.transform.position = new Vector3(transform.position.x, 0.5117913f, transform.position.z);

        animation_frame++;
	}
}
