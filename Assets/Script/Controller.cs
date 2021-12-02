using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{

    public GameObject Chair1;
    public GameObject Chair2;
    public GameObject Chair3;
    public GameObject Chair4;
    public GameObject Chair5;
    public GameObject Chair6;
    public GameObject Chair7;
    public GameObject Chair8;
    public GameObject Chair9;
    public GameObject Chair10;
    public Slider intervalSlider;
    public Slider boardWidthSlider;
    public Slider densityBack;

    bool isAutoBracketActive;

    private float intervals;
    private float widths;
    private float density;

    private float intervalsAuto;
    private float widthsAuto;
    private float densityAuto;


    // Start is called before the first frame update
    void Start()
    {
        setFalse();
        Chair2.SetActive(true);

        intervalsAuto = intervalSlider.value;
        widthsAuto = boardWidthSlider.value;
        densityAuto = densityBack.value;
    }

    // Update is called once per frame
    void Update()
    {
        intervals = intervalSlider.value;
        widths = boardWidthSlider.value;
        density = densityBack.value;

        if (intervalsAuto != intervals || widthsAuto != widths || densityAuto != density)
        {
            isAutoBracketActive = false;
        }

        if (isAutoBracketActive == false)
        {
            if (intervals < 0.04)
            {
                if(widths < 0.04)
                {
                    Chair1.SetActive(true);
                    Chair2.SetActive(false);
                    Chair3.SetActive(false);
                    Chair4.SetActive(false);
                    Chair5.SetActive(false);
                    Chair6.SetActive(false);
                    Chair7.SetActive(false);
                    Chair8.SetActive(false);
                    Chair9.SetActive(false);
                    Chair10.SetActive(false);
                }
                else {
                    Chair1.SetActive(false);
                    Chair2.SetActive(false);
                    Chair3.SetActive(false);
                    Chair4.SetActive(true);
                    Chair5.SetActive(false);
                    Chair6.SetActive(false);
                    Chair7.SetActive(false);
                    Chair8.SetActive(false);
                    Chair9.SetActive(false);
                    Chair10.SetActive(false);
                }
            }
            else if (intervals < 0.1)
            {
                if(widths < 0.04)
                {
                    if(density > 0.3)
                    {
                        Chair1.SetActive(false);
                        Chair2.SetActive(true);
                        Chair3.SetActive(false);
                        Chair4.SetActive(false);
                        Chair5.SetActive(false);
                        Chair6.SetActive(false);
                        Chair7.SetActive(false);
                        Chair8.SetActive(false);
                        Chair9.SetActive(false);
                        Chair10.SetActive(false);
                    }
                    else
                    {
                        Chair1.SetActive(false);
                        Chair2.SetActive(false);
                        Chair3.SetActive(false);
                        Chair4.SetActive(false);
                        Chair5.SetActive(false);
                        Chair6.SetActive(false);
                        Chair7.SetActive(true);
                        Chair8.SetActive(false);
                        Chair9.SetActive(false);
                        Chair10.SetActive(false);
                    }

                }
                else
                {
                    Chair1.SetActive(false);
                    Chair2.SetActive(false);
                    Chair3.SetActive(false);
                    Chair4.SetActive(false);
                    Chair5.SetActive(true);
                    Chair6.SetActive(false);
                    Chair7.SetActive(false);
                    Chair8.SetActive(false);
                    Chair9.SetActive(false);
                    Chair10.SetActive(false);
                }
            }
            else
            {
                if(widths < 0.04)
                {
                    if(density < 0.3)
                    {
                        Chair1.SetActive(false);
                        Chair2.SetActive(false);
                        Chair3.SetActive(false);
                        Chair4.SetActive(false);
                        Chair5.SetActive(false);
                        Chair6.SetActive(false);
                        Chair7.SetActive(false);
                        Chair8.SetActive(true);
                        Chair9.SetActive(false);
                        Chair10.SetActive(false);
                    }
                    else
                    {
                        Chair1.SetActive(false);
                        Chair2.SetActive(false);
                        Chair3.SetActive(true);
                        Chair4.SetActive(false);
                        Chair5.SetActive(false);
                        Chair6.SetActive(false);
                        Chair7.SetActive(false);
                        Chair8.SetActive(false);
                        Chair9.SetActive(false);
                        Chair10.SetActive(false);
                    }

                }
                else
                {
                    Chair1.SetActive(false);
                    Chair2.SetActive(false);
                    Chair3.SetActive(false);
                    Chair4.SetActive(false);
                    Chair5.SetActive(false);
                    Chair6.SetActive(true);
                    Chair7.SetActive(false);
                    Chair8.SetActive(false);
                    Chair9.SetActive(false);
                    Chair10.SetActive(false);
                }
            }
        }



    }

    void setFalse()
    {
        Chair1.SetActive(false);
        Chair2.SetActive(false);
        Chair3.SetActive(false);
        Chair4.SetActive(false);
        Chair5.SetActive(false);
        Chair6.SetActive(false);
        Chair7.SetActive(false);
        Chair8.SetActive(false);
        Chair9.SetActive(false);
        Chair10.SetActive(false);
    }

    public void optimization()
    {
        Chair1.SetActive(false);
        Chair2.SetActive(false);
        Chair3.SetActive(false);
        Chair4.SetActive(false);
        Chair5.SetActive(false);
        Chair6.SetActive(false);
        Chair7.SetActive(false);
        Chair8.SetActive(false);
        Chair9.SetActive(true);
        Chair10.SetActive(false);

        isAutoBracketActive = true;
        intervalsAuto = intervalSlider.value;
        widthsAuto = boardWidthSlider.value;
        densityAuto = densityBack.value;
    }

    public void autoBracket()
    {
        Chair1.SetActive(false);
        Chair2.SetActive(false);
        Chair3.SetActive(false);
        Chair4.SetActive(false);
        Chair5.SetActive(false);
        Chair6.SetActive(false);
        Chair7.SetActive(false);
        Chair8.SetActive(false);
        Chair9.SetActive(false);
        Chair10.SetActive(true);

        isAutoBracketActive = true;
        intervalsAuto = intervalSlider.value;
        widthsAuto = boardWidthSlider.value;
        densityAuto = densityBack.value;
    }

}
