using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToMenuButton : MonoBehaviour
{
    public GameObject PauseMenu;

    public void ExitSettings()
    {
        SceneManager.LoadScene(0);
    }

    public void ToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void ToGame()
    {
        Cursor.lockState = CursorLockMode.Locked;
        PauseMenu.SetActive(false);
        Time.timeScale = 1.0f;
    }

    private void Start()
    {
        PauseMenu.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.Confined;
            PauseMenu.SetActive(true);
            Time.timeScale = 0; 
        }
    }
}

