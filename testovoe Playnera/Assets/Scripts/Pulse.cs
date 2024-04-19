using UnityEngine;

public class Pulse : MonoBehaviour
{
    public float startScaleMultiplier = 0.5f;
    public float endScaleMultiplier = 1.5f;
    public float duration = 2f;

    private Vector3 originalScale;

    void Start()
    {
        originalScale = transform.localScale;
    }

    void Update()
    {
        float t = Mathf.PingPong(Time.time / duration, 1f);

        float scale = Mathf.Lerp(originalScale.x * startScaleMultiplier, originalScale.x * endScaleMultiplier, t);
        transform.localScale = new Vector3(scale, scale, scale);
    }
}
