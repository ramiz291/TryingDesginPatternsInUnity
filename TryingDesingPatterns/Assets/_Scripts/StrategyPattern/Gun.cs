using UnityEngine;

public class Gun : GunBase
{
    [SerializeField] private string gunName;
    [SerializeField] int magSize;
    [SerializeField] int fireRateee; //rate of fire in minute
    [SerializeField] int damageee;
    [SerializeField] FireMode fireModeee;

    private void OnEnable()
    {
        InitializeGunBase(this.magSize, fireRateee, damageee, fireModeee);
    }

}
