using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapsPage : MonoBehaviour
{
    public GameObject Map_1;
    public GameObject Map_2;

    public void nextB()
    {
        if(Map_2.active == false)
        {
            Map_1.SetActive(false);
            Map_2.SetActive(true);
        }
    }

    public void BackB()
    {
        if (Map_1.active == false)
        {
            Map_1.SetActive(true);
            Map_2.SetActive(false);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
