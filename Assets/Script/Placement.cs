using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class Placement : MonoBehaviour
{

    ARSessionOrigin sessionOrigin;
    ARRaycastManager raycastManager;
    List<ARRaycastHit> hits;
    public GameObject world;
    bool isAlreadyActive;
    // Start is called before the first frame update
    void Start()
    {
        sessionOrigin = FindObjectOfType<ARSessionOrigin>();
        raycastManager = FindObjectOfType<ARRaycastManager>();
        hits = new List<ARRaycastHit>();
        world.SetActive(false);
        isAlreadyActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        Touch touch = Input.GetTouch(0);
        if (Input.touchCount > 0 && !isAlreadyActive) //finger touches screen
        {
            //Vector2 middleScreen = new Vector2(Screen.width / 2, Screen.height / 2);
            if (raycastManager.Raycast(touch.position, hits))
            {
                world.SetActive(true);
                world.transform.position = hits[0].pose.position; //put the obj to the touch point
                isAlreadyActive = true;
            }
        }
    }
}

