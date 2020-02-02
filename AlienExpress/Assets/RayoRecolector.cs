using UnityEngine;
using System.Collections;

public class RayoRecolector : MonoBehaviour
{
    public Transform Player;

    public GameObject bull;
    //public Transform Rope;

    //private GameObject HookChild;
    //public Transform RopeChild;

    void Update()
    {
        Ray HookRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(HookRay.origin, HookRay.direction, Color.green);
        RaycastHit HookHit;

        if (Input.GetMouseButtonDown(0))
        {
            
            if (Physics.Raycast(HookRay, out HookHit))
            {
                Debug.DrawRay(HookRay.origin, HookRay.direction, Color.red);
                
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
         
        }
    }
}
