using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostItScript : MonoBehaviour
{
    public GameObject PostItToShow;

    void Start()
    {
        PostItToShow.SetActive(false);
    }

    public void ShowPostIt(GameObject objeto){
        if(objeto.GetComponent<Interactable>().origem == "Guitarra"){
            if(PostItToShow.activeSelf){
                PostItToShow.SetActive(false);
                return;
            }
            PostItToShow.SetActive(true);
        }
    }
}
