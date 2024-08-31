using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public GameObject GameOverText;
    public GameObject Crosshair;

    private void Start()
    {
        Crosshair.SetActive(true);
        GameOverText.SetActive(false);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("EndGameTag"))
        {
            Crosshair.SetActive(false);
            GameOverText.SetActive(true);
        }
    }
}
