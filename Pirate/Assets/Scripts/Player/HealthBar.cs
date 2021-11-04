using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthBar : MonoBehaviour
{
    public GameObject hearth1, hearth2, hearth3, gameOver;
    public static int health;
    public void Start()
    {
        health = 3;
        hearth1.gameObject.SetActive(true);
        hearth2.gameObject.SetActive(true);
        hearth3.gameObject.SetActive(true);
        gameOver.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (health > 3)
        {
            health = 3;
        }
            switch (health)
            {
                case 3:
                    hearth1.gameObject.SetActive(true);
                    hearth2.gameObject.SetActive(true);
                    hearth3.gameObject.SetActive(true);
                    break;
                case 2:
                    hearth1.gameObject.SetActive(true);
                    hearth2.gameObject.SetActive(true);
                    hearth3.gameObject.SetActive(false);
                    break;
                case 1:
                    hearth1.gameObject.SetActive(true);
                    hearth2.gameObject.SetActive(false);
                    hearth3.gameObject.SetActive(false);
                    break;
                case 0:
                    hearth1.gameObject.SetActive(false);
                    hearth2.gameObject.SetActive(false);
                    hearth3.gameObject.SetActive(false);
                    gameOver.gameObject.SetActive(true);
                    Time.timeScale = 0;
                    break;
            }
        
    }
}
