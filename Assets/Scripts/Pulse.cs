using UnityEngine;

public class Pulse : MonoBehaviour
{
    public AnimationCurve Curve;
    public float t = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime * 2;
        if (t > 1)
        {
            t = 0;
        }

        float y = Curve.Evaluate(t);

        transform.localScale = Vector3.one *  Curve.Evaluate(t);
    }
}
