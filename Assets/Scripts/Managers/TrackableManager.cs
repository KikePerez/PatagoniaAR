using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class TrackableManager : MonoBehaviour {

    public  Monster[]                MonsterList;
    public  static      bool         Scanning;

    //TESTING
   // public GameObject textFound;
    //END TESTING

    public void Awake() {
        EventsManager._trackableFound += TrackableCallbackFound;
        EventsManager._trackableLost+= TrackableCallbackLost;
    }
    public void TrackableCallbackFound(string TrackableName) {
        if (Scanning) {
            EventsManager.GoToScreen("attack_mode");
        }
    }
    public void TrackableCallbackLost(string TrackableName)
    {
        if (Scanning) {
            EventsManager.GoToScreen("detection_lost");
        }
    }
}
