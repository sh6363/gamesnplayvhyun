using UnityEngine;

public class SpeedCalculator : MonoBehaviour
{
    private Vector3 lastPosition;
    private float distanceAccumulated = 0f;
    private float timeAccumulated = 0f;
    public float speed;
    public float updateInterval = 0.1f;

    void Start()
    {
        lastPosition = transform.position;
    }

    void Update()
    {
        distanceAccumulated += Vector3.Distance(transform.position, lastPosition);

        timeAccumulated += Time.deltaTime;

        lastPosition = transform.position;

        if (timeAccumulated >= updateInterval)
        {
            speed = distanceAccumulated * 4 / timeAccumulated;

            distanceAccumulated = 0f;
            timeAccumulated = 0f;
        }
    }
}
