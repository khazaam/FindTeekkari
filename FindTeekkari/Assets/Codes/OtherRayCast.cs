using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour
{

    //This is for shooting randon things
    public float Range = 1000;
    public float Force = 1000;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("X"))
            RayShoot();
    }

    void RayShoot()
    {
        Vector3 DirectionRay = transform.TransformDirection(Vector3.forward);
        Debug.DrawRay(transform.position, DirectionRay * Range, Color.blue);
        RaycastHit Hit;
        if (Physics.Raycast(transform.position, DirectionRay, out Hit, Range))
        {
            if (Hit.collider.CompareTag("Interactable"))
            {
                Debug.Log("Hit");
            }
        }
    }
}