using UnityEngine;
using System.Collections;

public class InventoryGUI : MonoBehaviour {
    public GameObject MoreInfoModal;

    public void ToggleMoreInfo() {
        MoreInfoModal.SetActive(!MoreInfoModal.activeSelf);
    }
	
}
