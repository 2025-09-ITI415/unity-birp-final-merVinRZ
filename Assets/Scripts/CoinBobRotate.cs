using UnityEngine;

public class CoinBobRotate : MonoBehaviour
{
    [Header("Rotate")]
    public float rotateSpeed = 120f;

    [Header("Bob")]
    public float bobAmplitude = 0.25f;
    public float bobFrequency = 1.5f;

    private Vector3 startLocalPos;

    void Start()
    {
        startLocalPos = transform.localPosition;
    }

    void Update()
    {
        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime, Space.World);
        float offset = Mathf.Sin(Time.time * Mathf.PI * 2f * bobFrequency) * bobAmplitude;
        transform.localPosition = startLocalPos + new Vector3(0f, offset, 0f);
    }
}