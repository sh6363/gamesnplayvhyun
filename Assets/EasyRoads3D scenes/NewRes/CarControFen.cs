using System.Collections;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using UnityEngine;

public class CarControFen : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        FollowCar.CountDian = 0;
        FollowCar.CountFood = 0;
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.R))
        //{
        //    gameObject.transform.position = new Vector3(Random.Range(-5, 5), 10, Random.Range(-5, 5));
        //}
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Count")
        {
            FollowCar.CountDian++;
        }
        if (other.name=="zhong"&& FollowCar.CountDian>5)
        {
            FollowCar.CountDian=0;
            FollowCar.CountFood++;
            if (FollowCar.CountFood>=3)
            {
                Time.timeScale = 0;
                HUBController.OverUI?.SetActive(true);
            }
        }
    }
}
