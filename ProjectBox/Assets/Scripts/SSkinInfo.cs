using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable, CreateAssetMenu(fileName ="New Skin", menuName ="Create New Skin")]
public class SSkinInfo : ScriptableObject
{
    public enum SkinIDs {pink, green, blue, dice, knots, panda, test}
    public SkinIDs skinID;

    public Sprite skinSprite;

    public int skinPrice;
}
