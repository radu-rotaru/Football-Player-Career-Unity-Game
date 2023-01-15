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
    public float powerSpeed = 25.0f;
    public float maxPower = 30.0f;
    public float minPower = 15.0f;

    public static bool chosen = false;
    public bool done = false;

    void Start()
    {
        chosen = false;
    }

    void Update()
    {
        if (!chosen && isPowerUp)
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
        chosen = true;
        Shooting.power = powerAmount;
        isPowerUp = false;

/*        if(!done && Direction.chosen)
        {
            done = true;
            Shooting.isShooting = true;
        }*/
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
