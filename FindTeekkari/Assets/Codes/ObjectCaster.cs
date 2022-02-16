using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectCaster : MonoBehaviour
{
    public static string selectedThing;
    public string internalThing;

    public string OtherThingForTextUI;
    //For some reason, only boxcollider works with this.

    Text TextFromObjects;
    public RaycastHit theThing;

    // Update is called once per frame

    void Start()
    {
        TextFromObjects = GameObject.Find("MainText").GetComponent<Text>();
    }
    void Update()
    {
        TextFromObjects.text = null;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out theThing))
        {
            if (theThing.collider.CompareTag("Interactable"))
            {
                //Names of objects
                selectedThing = theThing.transform.gameObject.name;
                internalThing = theThing.transform.gameObject.name;
                //Name shown on the screen when hit by collider
                TextFromObjects.text = (theThing.collider.name);

                Debug.Log("Hit the right spot!");
            }
            else
            {
                Debug.Log("Did not hit the right spot");
            }



        }

    }

}
