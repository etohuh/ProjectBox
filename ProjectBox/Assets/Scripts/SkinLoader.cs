using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinLoader : MonoBehaviour
{
    public SpriteRenderer playerSR;

    private void Start()
    {
        playerSR.sprite = SkinManager.equippedSkin;
    }
}
