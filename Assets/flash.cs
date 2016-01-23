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
        // Flash point light 
        float phi = Time.time / duration2 * 2 * Mathf.PI;
        float amplitude =  2*(Mathf.Cos(phi)*Mathf.Cos(2*phi))+ 2.05f;
        lt.intensity = amplitude;
        animation_frame++;
    }
}
