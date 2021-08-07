using UnityEngine;
using System.Collections.Generic;

public class GunBase : MonoBehaviour
{
    protected int magazineSize;
    protected int fireRate; //rate of fire in minute
    protected int damage;
    protected List<FireMode> fireModes;
    FireMode activeFireMode;
    bool hasFired;

    protected IFireBehavior trigger;
    protected void SetTrigger(IFireBehavior fb)
    {
        trigger = fb;
    }

    protected void InitializeGunBase(int magSize, int fireRate, int damage, List<FireMode> fireMode)
    {
        magazineSize = magSize;
        this.fireRate = fireRate;
        this.damage = damage;
        fireModes = fireMode;
        activeFireMode = fireModes[0];
    }

    protected void PullTrigger()
    {
        hasFired = true;
    }
    
    protected void ReleaseTrigger()
    {
        hasFired = false;
    }

    public RaycastHit Fire()
    {
        RaycastHit hitInfo = new RaycastHit();

        switch(activeFireMode)
        {
            case FireMode.semiauto:
                //Semi Auto fire routine
                Debug.Log("Single Shot");
                break;
            case FireMode.burst:
                //Burst fire routine
                Debug.Log("Burst Fire");
                break;
            case FireMode.auto:
                //Full Auto fire routine
                Debug.Log("Automatic Fire");
                break;
        }

        return hitInfo;
    }
}

public enum FireMode
{
    semiauto = 1,
    burst = 2,
    auto = 3
}

public interface IFireBehavior
{
    RaycastHit Fire();
}


public class SingleShotFire : IFireBehavior
{

    public RaycastHit Fire()
    {
        RaycastHit hitInfo = new RaycastHit();

        Debug.Log("Firing a bullet");

        return hitInfo;
    }
}