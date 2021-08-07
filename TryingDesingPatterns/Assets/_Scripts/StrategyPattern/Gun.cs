using UnityEngine;

public class Gun : GunBase
{
    [SerializeField] GunData gunData;

    //IK Constraints
    [Header("Hand IK Related Properties")]
    public Transform rightHandIkTransform;
    public Transform leftHandIkTransform; 

    private void OnEnable()
    {
        InitializeGunBase(gunData.magSize, gunData.fireRate, gunData.damage, gunData.fireModes);
    }


    //called when user picks up this gun
    public bool GunPickup()
    {
        return false;
    }
}
