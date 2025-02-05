using UnityEngine;

public class PowerUpCoins : PowerUpBase
{
    public PlayerController playerController;

    [Header("Coin Collector")]
    public float sizeAmount = 7;

    public override void StartPowerUp()
    {
        base.StartPowerUp();
        playerController.ChangeCoinsCollectorSize(sizeAmount);
    }

    public override void EndPowerUp()
    {
        base.EndPowerUp();
        playerController.ChangeCoinsCollectorSize(1);
        gameObject.SetActive(false);
    }
}
