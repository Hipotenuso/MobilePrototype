using UnityEngine;

public class PowerUpInvencible : PowerUpBase
{
    public PlayerController playerController;

    public override void StartPowerUp()
    {
        base.StartPowerUp();
        playerController.SetPowerUpText("Invencible");
        playerController.SetInvencible(true);
    }
    public override void EndPowerUp()
    {
        base.EndPowerUp();
        playerController.SetInvencible(false);
        playerController.SetPowerUpText("");
        gameObject.SetActive(false);
    }
}

