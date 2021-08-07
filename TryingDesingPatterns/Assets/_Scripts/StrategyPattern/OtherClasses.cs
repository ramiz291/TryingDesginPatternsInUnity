using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class OtherClasses
{
    
}

public interface IPickupable<T>
{
    PickupData<T> PickUp();
}

public class PickupData<T>
{
    private T _object;
    PickupType pickupType;
    public PickupData(T data, PickupType pickupType)
    {
        _object = data;
        this.pickupType = pickupType;
    }

    public T GetData()
    {
        return _object;
    }
}

public enum PickupType
{
    coin, gun, bullet, throwable
}