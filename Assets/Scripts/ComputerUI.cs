using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComputerUI : MonoBehaviour
{
    public GameObject ui;
    public string correctPassword = "password"; // Change this to your correct password
    private InputField passwordInputField;
    private bool isUIVisible = false;

    void Start()
    {
        HideUI();
        // Find the InputField component within the children of the UI GameObject
        passwordInputField = ui.GetComponentInChildren<InputField>();
        if (passwordInputField == null)
        {
            Debug.LogError("InputField not found in UI GameObject.");
        }
        else
        {
            Debug.Log("InputField found: " + passwordInputField.gameObject.name);
        }
        Debug.Log("Computer script running");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ShowUI();
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

        // Set the input field as focused and activated when showing the UI
        if (passwordInputField != null)
        {
            passwordInputField.Select();
            passwordInputField.ActivateInputField();
        }
    }

    public void PressExit()
    {
        HideUI();
    }

    public void SubmitPassword()
    {
        if (passwordInputField != null)
        {
            string password = passwordInputField.text;
            if (password == correctPassword)
            {
                CorrectAnswer();
            }
            else
            {
                WrongAnswer();
            }
        }
    }

    public void OnEndEdit()
    {
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            SubmitPassword();
        }
    }

    public void CorrectAnswer()
    {
        // Add code to trigger door animation here
        Debug.Log("Correct password entered. Door opening...");
        HideUI(); // Hide the UI after correct password is entered
    }

    public void WrongAnswer()
    {
        Debug.Log("Wrong password entered. Try again.");
        // You can add feedback for the player here, like showing an error message
    }
}
