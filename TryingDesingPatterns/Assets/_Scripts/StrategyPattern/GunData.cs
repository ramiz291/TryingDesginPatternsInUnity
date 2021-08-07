using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "Gun", menuName = "New Gun")]
[System.Serializable]
public class GunData : ScriptableObject
{
    public string gunName;
    public int magSize;
    public int fireRate; //rate of fire in minute
    public int damage;
    public List<FireMode> fireModes;

    public Vector3 normalPosition;
    public Vector3 adsPosition;
    [Range(0.1f,1f)]
    public float adsSpeed = 0.5f;

    
}
