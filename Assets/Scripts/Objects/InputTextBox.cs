using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputTextBox : MonoBehaviour
{
    public TMPro.TMP_InputField passwordInputField;
    public TMPro.TMP_Text messageText;
    private string correctPassword = "NCVI"; // Set your correct password here

    // Start is called before the first frame update
    void Start()
    {
        messageText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            CheckPassword();
        }
    }

    public void CheckPassword()
    {
        if (passwordInputField.text == correctPassword)
        {
            messageText.text = "Password correct!";
            // Add your logic for correct password here
        }
        else
        {
            messageText.text = "Wrong password";
        }
    }
}
