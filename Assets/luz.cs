using UnityEngine;

public class luz : MonoBehaviour
{
    public float intensityBase = 3f;
    public float intensityVariation = 1.5f;
    public float speed = 8f;

    Light l;

    void Start()
    {
        l = GetComponent<Light>();
    }

    void Update()
    {
        float flicker = Mathf.PerlinNoise(Time.time * speed, 0f);
        l.intensity = intensityBase + (flicker - 0.5f) * intensityVariation;
    }
}
