using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ARSceneController : MonoBehaviour
{

    private int arStatue = 0;
    public GameObject Chair1;
    public GameObject Chair2;
    public GameObject Chair3;
    public GameObject Chair4;
    public GameObject Chair5;

    public void nextObj()
    {
        arStatue = arStatue + 1;
    }

    public void previousOjb()
    {
        arStatue = arStatue - 1;
    }


    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        if(arStatue == 0)
        {
            Chair1.SetActive(true);
            Chair2.SetActive(false);
            Chair3.SetActive(false);
            Chair4.SetActive(false);
            Chair5.SetActive(false);
        }
        else if (arStatue == 1)
        {
            Chair1.SetActive(false);
            Chair2.SetActive(true);
            Chair3.SetActive(false);
            Chair4.SetActive(false);
            Chair5.SetActive(false);
        }
        else if(arStatue == 2)
        {
            Chair1.SetActive(false);
            Chair2.SetActive(false);
            Chair3.SetActive(true);
            Chair4.SetActive(false);
            Chair5.SetActive(false);
        }
        else if(arStatue == 3)
        {
            Chair1.SetActive(false);
            Chair2.SetActive(false);
            Chair3.SetActive(false);
            Chair4.SetActive(true);
            Chair5.SetActive(false);
        }
        else if(arStatue == 4)
        {
            Chair1.SetActive(false);
            Chair2.SetActive(false);
            Chair3.SetActive(false);
            Chair4.SetActive(false);
            Chair5.SetActive(true);
        }
        else if(arStatue < 0)
        {
            arStatue = 0;
        }
        else
        {
            arStatue = 4;
        }
    }
}
