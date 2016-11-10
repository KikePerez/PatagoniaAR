using UnityEngine;
using System.Collections;
using Vuforia;
public class MarkerDetector : MonoBehaviour
{
    public string id;
    public GameObject UICallback;

    public void OnTrackingFound() {
        Debug.Log(id+" detectado");
        UICallback.SetActive(true);
    }

    public void OnTrackingLost()
    {
        Debug.Log(id + " no detectado");
        UICallback.SetActive(false);
    }


    
    
    
}
