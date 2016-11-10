using UnityEngine;
using System.Collections;
using Vuforia;
public class EventsManager : MonoBehaviour {

    public delegate void SimpleDelegateWithString(string trackableName);
    
    //TRACKABLE EVENTS
    public static SimpleDelegateWithString _trackableFound;
    public static SimpleDelegateWithString _trackableLost;
    //UI EVENTS
    public static SimpleDelegateWithString _GoToScreen;

    public static void GoToScreen(string screenName)
    {
        _GoToScreen(screenName);
    }

    public static void TrackableFound(string trackableName) {
        _trackableFound(trackableName);
    }
    public static void TrackableLost(string trackableName)
    {
        _trackableLost(trackableName);
    }
}
