using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControll : MonoBehaviour
{

    public GameObject ShowThisChoose;

    public GameObject CarChoose;
    public GameObject SceneChoose;

    public GameObject Car1;
    public GameObject Car2;
    void Start()
    {
        Car2?.SetActive(false);
    }

  
    void Update()
    {
        
    }

    public void ShowUi()
    {
        ShowThisChoose.SetActive(true);
       // Time.timeScale = 0f;
    } 
    public void DontShowUi()
    {
        ShowThisChoose.SetActive(false);
      //  Time.timeScale = 1f;
    }

    public void Scene01()
    {
        SceneManager.LoadScene("test scene");
    } public void Scene02()
    {
        SceneManager.LoadScene("scene01");
    }

    public void DontShowCar()
    {
        CarChoose.SetActive(false);
        Time.timeScale = 1f;
    }

    public void DontShowScene()
    {
        SceneChoose.SetActive(false);
        Time.timeScale = 1f;
    }

    public void ShowCar()
    {
        CarChoose.SetActive(true);
    }

    public void ShowScene()
    {
        SceneChoose.SetActive(true);
    }

    public void QieCar()
    {
        DontShowScene();
        ShowCar();
    }

    public void QieScene()
    {
        DontShowCar();
        ShowScene();
    }

    public void ChooseCar1()
    {
        Car2.SetActive(false);
        Car1.SetActive(true);

    } public void ChooseCar2()
    {
        Car1.SetActive(false);
        Car2.SetActive(true);
    }
}
