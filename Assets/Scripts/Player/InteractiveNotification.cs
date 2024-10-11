using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveNotification : MonoBehaviour
{
    public GameObject InteractiveNotificationButton;
    void Start()
    {
        InteractiveNotificationButton.SetActive(false);
    }

    public void SetInteractable(bool value)
    {
        InteractiveNotificationButton.SetActive(value);
    }
}
