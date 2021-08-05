using UnityEngine;

public class GunController : MonoBehaviour
{
    [SerializeField] private Gun currentGun;


    private void Update()
    {
        if(currentGun != null)
        {
            if(Input.GetKeyDown(KeyCode.Mouse0))
                currentGun.Fire();
        }
    }

}
