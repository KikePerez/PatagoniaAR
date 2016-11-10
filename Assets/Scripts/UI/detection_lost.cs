using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class detection_lost : MonoBehaviour {

    public float    goal=10;
    public float    counter=10;
    public bool     is_counting;
    [SerializeField]
    private Text    ui_counter;

    private void OnEnable() {
        is_counting = true;
        counter = 10;
    }
    private void OnDisable() {
        is_counting = false;
        counter = 10;        
    }
	
	// Update is called once per frame
	void Update () {
        if (is_counting) {
            ui_counter.text = counter.ToString("0");
            if (counter<0) {
                EventsManager.GoToScreen("search_mode");
                counter =   goal;
            }
            counter -= Time.deltaTime;
        }
	}
}
