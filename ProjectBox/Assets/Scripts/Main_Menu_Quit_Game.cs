using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_Menu_Quit_Game : MonoBehaviour
{
    public void QuitGame()
    {
        print("Quitting game!");
        Application.Quit();
    }
}
