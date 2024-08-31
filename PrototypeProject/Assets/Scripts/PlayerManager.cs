using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    #region Singleton 
    public static PlayerManager instance;
    private void Awake()
    {
        instance = this;
    }
    #endregion
    public GameObject player;
    public GameObject door1;
    public static int playerHealth;
    public static bool gameOver;
    public TextMeshProUGUI playerHealthText;

    private void Start()
    {
        playerHealth = 100;
        gameOver = false;
    }

    private void Update()
    {
        playerHealthText.text = "" + playerHealth;
        if (gameOver)
        {
            SceneManager.LoadScene(1);
        }
    }

    public static void Damage(int damageCount)
    {
        playerHealth -= damageCount;

        if (playerHealth <= 0)
        {
            SceneManager.LoadScene(3);
            Cursor.lockState = CursorLockMode.Confined;
        }
    }
}
