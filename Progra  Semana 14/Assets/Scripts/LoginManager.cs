using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameJolt.UI;
using UnityEngine.SceneManagement;

public class LoginManager : MonoBehaviour
{
    void Start()
    {
        GameJoltUI.Instance.ShowSignIn((bool signedIn) => {
            if (signedIn)
            {
                SceneManager.LoadScene("Level1Scene");
            }
            else
            {
                Debug.Log("error");
            }
        });
    }
}
