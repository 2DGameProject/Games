using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteracbleObject : ColliderObject
{
    protected override void OnCollided(GameObject collidedObject)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {

        }
    }

    private void OnInteract()
    {
        Debug.Log("Interacted with " + gameObject.name);
    }
}
