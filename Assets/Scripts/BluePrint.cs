using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BluePrint : MonoBehaviour

{
    public GameObject ui;
    private bool isUIVisible = false;

    void Start()
    {
        HideUI();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ShowUI();
        }
    }

private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            HideUI();
        }
    }

    public void HideUI()
    {
        ui.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        isUIVisible = false;
    }

    public void ShowUI()
    {
        ui.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        isUIVisible = true;
    }

    public void PressExit()
    {
        HideUI();
    }
}

