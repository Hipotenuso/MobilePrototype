using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PowerUpSpeed : PowerUpBase
{
    public PlayerController playerController;

    [Header("Power Up Speed")]
    public float amountToSpeed;

    public override void StartPowerUp()
    {
        base.StartPowerUp();
        playerController.PowerUpSpeedUp(amountToSpeed);
        playerController.SetPowerUpText("Speed Up"); 
    }

    public override void EndPowerUp()
    {
        playerController.ResetSpeed();
        playerController.SetPowerUpText("");
        gameObject.SetActive(false);
    }
}
