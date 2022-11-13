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
    private float powerSpeed = 25.0f;
    private float maxPower = 30.0f;
    private float minPower = 5.0f;

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
        powerAmount = minPower;
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
            if(powerAmount > maxPower)
            {
                isPowerIncreasing = false;
                powerAmount = maxPower;
            }
        }
        else
        {
            powerAmount -= Time.deltaTime * powerSpeed;
            if (powerAmount < minPower)
            {
                isPowerIncreasing = true;
                powerAmount = minPower;
            }
        }

        imagePoewrUp.fillAmount = (0.5f - 0.25f) * (powerAmount - minPower) / (maxPower - minPower) + 0.25f;
    }
}
