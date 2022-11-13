using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUp : MonoBehaviour
{
    [SerializeField]
    private Image imagePoewrUp;

    private bool isPowerUp = false;
    private bool isPowerIncreasing = true;
    public static float powerAmount = 0.0f;
    private float powerSpeed = 100.0f;

    // Update is called once per frame
    void Update()
    {
        if (isPowerUp)
        {
            PowerBarMovement();
        }
    }

    public void StartPowerUp()
    {
        isPowerUp = true;
        powerAmount = 0.0f;
        isPowerIncreasing = true;
    }

    public void EndPowerUp()
    {
        Shooting.power = powerAmount;
        isPowerUp = false;
    }

    public void PowerBarMovement()
    {
        if(isPowerIncreasing)
        {
            powerAmount += Time.deltaTime * powerSpeed;
            if(powerAmount > 100.0f)
            {
                isPowerIncreasing = false;
                powerAmount = 100.0f;
            }
        }
        else
        {
            powerAmount -= Time.deltaTime * powerSpeed;
            if (powerAmount < 0.0f)
            {
                isPowerIncreasing = true;
                powerAmount = 0.0f;
            }
        }

        imagePoewrUp.fillAmount = (0.5f - 0.25f) * powerAmount / 100.0f + 0.25f;
    }
}
