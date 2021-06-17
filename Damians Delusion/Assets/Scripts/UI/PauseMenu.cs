using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{

    void OnEnable()
    {
        GameObject inventoryPanel = InventoryController.instance.InventoryPanel;
        Time.timeScale = 0;
        InventoryController.instance.Player.GetComponentInChildren<cameraLook>().enabled = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    void OnDisable()
    {
        GameObject inventoryPanel = InventoryController.instance.InventoryPanel;
        Time.timeScale = 1;
        InventoryController.instance.Player.GetComponentInChildren<cameraLook>().enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void QuitGame()
    {
        Debug.Log("cona");
        Application.Quit();
    }

}