using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerUI : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ui;
    void Start()
    {
        HideUI();
         Debug.Log("Computer script running");

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
        {
            Debug.Log("Collision with computer");
            if(other.tag == "Player")
            {
                ShowUI();
            }
        }
public void HideUI()
{
    ui.SetActive(false);

    Cursor.lockState = CursorLockMode.Locked;
    Cursor.visible = false;
    }

public void ShowUI()
{
    ui.SetActive(true);

    Cursor.lockState = CursorLockMode.None;
    Cursor.visible = true;
    }
public void PressExit()
    {
HideUI();
    }
    public void CorrectAnswer()
    {

    }

        public void WrongAnswer()
    {
        
    }

}
