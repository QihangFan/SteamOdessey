using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnTable : MonoBehaviour
{
    private float speed;
    public Slider slider;

    void Update()
    {
        speed = slider.value;
        transform.Rotate(0, -speed * Time.deltaTime, 0);
    }
}
