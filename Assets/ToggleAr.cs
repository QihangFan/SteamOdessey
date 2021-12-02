using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class ToggleAr : MonoBehaviour
{
    public ARPlaneManager planeManager;
    public ARPointCloudManager pointCloudManager;
    private GameObject myToggle; 

    public void OnValueChanged()
    {

        myToggle = GameObject.Find("Toggle");
        bool isOn = myToggle.GetComponent<UnityEngine.UI.Toggle>().isOn;
        VisualizePlanes(isOn);
        VisualizePoints(isOn);

        Debug.Log(isOn);
    }

    void VisualizePlanes(bool active)
    {
        planeManager.enabled = active;
        foreach(ARPlane plane in planeManager.trackables)
        {
            plane.gameObject.SetActive(active);
        }
    }

    void VisualizePoints(bool active)
    {
        pointCloudManager.enabled = active;
        foreach(ARPointCloud point in pointCloudManager.trackables)
        {
            point.gameObject.SetActive(active);
        }
    }

}
