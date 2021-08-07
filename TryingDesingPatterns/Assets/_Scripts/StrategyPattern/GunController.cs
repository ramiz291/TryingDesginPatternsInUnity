using UnityEngine;

public class GunController : MonoBehaviour
{
    [SerializeField] private Gun currentGun;


    private void Update()
    {
#if UNITY_EDITOR //editor codes
        if(currentGun != null)
        {
            if(Input.GetKeyDown(KeyCode.Mouse0))
                currentGun.Fire();
        }
#endif
    }

    

}
