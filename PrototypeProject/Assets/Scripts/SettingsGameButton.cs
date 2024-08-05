using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsGameButton : MonoBehaviour
{
    public void SettingsMenu()
    {
        SceneManager.LoadScene(2);
    }
}
