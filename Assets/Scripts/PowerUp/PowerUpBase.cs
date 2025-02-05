using UnityEngine;

public class PowerUpBase : ItemCBase
{
    [Header("Power Up")]
    public float duration;

    protected override void OnCollect()
    {
        base.OnCollect();
        StartPowerUp();
    }

    public virtual void StartPowerUp()
    {
        Invoke(nameof(EndPowerUp), duration);
        Debug.Log("Start Power Up");

    }

    public virtual void EndPowerUp()
    {
        Debug.Log("End Power Up");
    }
}
