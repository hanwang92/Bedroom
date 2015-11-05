using UnityEngine;
using System.Collections;

public class flash : MonoBehaviour {

    public float duration = 1.0F;
    public float duration2 = 1.0F;
    public Light lt;
    int animation_frame = 0;
    int count = 100;
    int count2 = 200;

    void Start()
    {
        lt = GetComponent<Light>();
    }
    void Update()
    {
        /*
        if((animation_frame > count)&& (animation_frame < count+10))
        {
            float phi = Time.time / duration * 2 * Mathf.PI;
            float amplitude = Mathf.Cos(phi) * 0.5F + 0.5F;
            lt.intensity = amplitude/10;
            if(animation_frame == count + 9)
            {
                count += (int)Random.Range(200.0F, 500.0F);
            }
        }

        else
        {
            float phi = Time.time / duration2 * 2 * Mathf.PI;
            float amplitude = Mathf.Cos(phi) * 0.5F + 0.5F;
            lt.intensity = amplitude;
        }*/

        float phi = Time.time / duration2 * 2 * Mathf.PI;
        float amplitude =  2*(Mathf.Cos(phi)*Mathf.Cos(2*phi))+ 2.05f;
        lt.intensity = amplitude;

        animation_frame++;
    }
}
