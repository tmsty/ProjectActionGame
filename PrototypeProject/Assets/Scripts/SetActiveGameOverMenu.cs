using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActiveGameOverMenu : MonoBehaviour
{
    public GameObject GameOverMenu;
    public GameObject _Player;
    public void Update()
    {
        if (_Player.transform.position.x > 131)
        {
            GameOverMenu.SetActive(true);
        }
    }
}
