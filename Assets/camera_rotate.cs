using UnityEngine;
using System.Collections;

public class camera_rotate : MonoBehaviour {

	int animation_frame = 0;
    public Fader fade;
    float adjust = 0.0f;

    void Start ()
    {
        fade = FindObjectOfType(typeof(Fader)) as Fader;
    }
	
	// Update is called once per frame
	void Update () {
        GameObject floor;
        floor = GameObject.Find("FLOOR");
        Vector3 newpos = floor.transform.forward;
        //newpos.x = newpos.x - adjust;
        newpos.z = newpos.z - adjust;

        if (animation_frame < 760)
        {
            transform.Rotate(-newpos * Time.deltaTime * 10);
        }
        else if (animation_frame < 780)
        {
            transform.Rotate(-newpos * Time.deltaTime * 5);

        }
        if (animation_frame > 680)
        {
            fade.EndScene();
        }
        if (animation_frame < 200)
        {
            adjust += 0.06f * Time.deltaTime;
        }
        else if (200 < animation_frame && animation_frame < 500)
            adjust -= 0.03f * Time.deltaTime;
        if (animation_frame == 780)
            Application.Quit();

        animation_frame++;
	}
	
}
