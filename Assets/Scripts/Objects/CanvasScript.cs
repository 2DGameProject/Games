using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasScript : MonoBehaviour
{
    public GameObject CanvasToShow;

    void Start()
    {
        CanvasToShow.SetActive(false);
    }

    public void ShowCanvas(GameObject objeto)
    {
        if ( objeto.GetComponent<Interactable>().origem == "Porta" )
        {
            if(CanvasToShow.activeSelf){
                CanvasToShow.SetActive(false);
                return;
            }
            CanvasToShow.SetActive(true);
        }
    }
}

