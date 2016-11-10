using UnityEngine;
using System.Collections;

public class CameraManager : MonoBehaviour {

    public GameObject VuforiaCam;
    public GameObject UICam;

    public void Start() {
        StartCoroutine(Init());
    }

    public IEnumerator Init() {
        yield return new WaitForSeconds(0.5f);
        ToggleVuforiaCam(false);
    }

    public void ToggleVuforiaCam(bool toggle) {
        VuforiaCam.SetActive(toggle);
        UICam.SetActive(!toggle);
    }
}
