using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuScript : MonoBehaviour {

    public void ChangeScene (string menu)
    {

        SceneManager.LoadScene(menu);
    }
    public void OnStartGame()
    {
        Debug.Log("You pressed start game!");
    }
}
