using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUBController : MonoBehaviour
{
    // Start is called before the first frame update

    private Text countUI;
    private Text FenUI;

    public static GameObject OverUI;
    void Start()
    {
        OverUI = GameObject.Find("OverUI");
        OverUI?.SetActive(false);
        countUI = GameObject.Find("countUI").GetComponent<Text>();
        FenUI = GameObject.Find("FenUI").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        float speed = FindAnyObjectByType<SpeedCalculator>().speed;
        countUI.text = "Count:"+FollowCar.CountFood.ToString();
        FenUI.text = "Speed:"+  Mathf.Abs(speed).ToString("00");
    }
}
