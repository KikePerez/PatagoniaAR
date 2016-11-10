using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class UIManager : MonoBehaviour {

    public List<GameObject> UIScreens;
    public string ActualScreen;

    private void Start() {
        EventsManager._GoToScreen += GoToScreen;
        FillUIScreens();
        GoToScreen(ActualScreen);
    }

    public void GoToScreen(string screenName) {
        CloseAllScreens();
        GameObject screen = FindScreen(screenName);
        if (screenName=="search_mode") {
            TrackableManager.Scanning = true;
        }
        if (screenName == "main_menu")
        {
            TrackableManager.Scanning = false;
        }
        screen.SetActive(true);
    }
    private void FillUIScreens() {
        UIScreens = new List<GameObject>();
        foreach (Transform tr in transform) {
            UIScreens.Add(tr.gameObject);
        }
    }
    private void CloseAllScreens() {
        foreach (GameObject screen in UIScreens)
        {
            screen.SetActive(false);
        }
    }
    private GameObject FindScreen(string screenName) {
        foreach (GameObject screen in UIScreens) {
            if (screen.name==screenName) {
                return screen;
            }
        }
        return null;
    }

}
