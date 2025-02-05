using DG.Tweening;
using UnityEngine;

public class PowerUpFly : PowerUpBase
{
    public PlayerController playerController;

    [Header("Power Up Fly")]
    public float amountheight = 2;
    public float animationDuration = .1f;
    public DG.Tweening.Ease ease = DG.Tweening.Ease.OutBack;

    public override void StartPowerUp()
    {
        base.StartPowerUp();
        playerController.ChangeHeight(amountheight, duration, animationDuration, ease);
        playerController.SetPowerUpText("Flying"); 
    }

    public override void EndPowerUp()
    {
        base.EndPowerUp();
        playerController.ResetHeight();
        playerController.SetPowerUpText("");
        gameObject.SetActive(false);
    }
}
