using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NEwCar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Text", .2f);
    }

    public void Text()
    {
        GameObject go = GameObject.Find("MainMenuUI(Clone)");
        go?.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
