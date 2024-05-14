using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCar : MonoBehaviour
{
    // Start is called before the first frame update
    public static int CountDian;
    public static int CountFood;
    public GameObject car;
    public GameObject car2;

    public Vector3 v3 = new Vector3(0,10f,0);
    void Start()
    {
        if (car.active == false)
        {
            gameObject.transform.position = v3 + car2.transform.position;
        }
        else
        {
            gameObject.transform.position = v3 + car.transform.position;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (car.active == false)
        {
            gameObject.transform.position = v3 + car2.transform.position;
        }
        else
        {
            gameObject.transform.position = v3 + car.transform.position;
        }
    }
}
