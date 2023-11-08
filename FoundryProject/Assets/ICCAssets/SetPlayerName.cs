using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SetPlayerName : MonoBehaviour
{
    public TMP_InputField userNameInput;
    private string userName;

    private void Start()
    {
        if (PlayerPrefs.HasKey("usernameLAN"))
        {
            userNameInput.text = PlayerPrefs.GetString("usernameLAN");
        }
        
    }

    private void UpdateUserName()
    {
        userName = userNameInput.GetComponent<TMP_InputField>().text;
        PlayerPrefs.SetString("usernameLAN", userName);
    }

    
}
