using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class SkinInShop : MonoBehaviour
{
    public SSkinInfo skinInfo;

    public Text buttonText;
    public Image skinImage;
    public GameObject go;
    public Button skinBuyButton;

    public bool isSkinUnlocked;
    [SerializeField] SpriteRenderer avatarSprite;

    [SerializeField] Animator NoMoneyAnim;
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip cashRegister;

    private void Awake()
    {
        skinImage.sprite = skinInfo.skinSprite;
        IsSkinUnlocked();
        ChangeSprite();
    }

    private void IsSkinUnlocked()
    {
        if (PlayerPrefs.GetInt(skinInfo.skinID.ToString()) == 1)
        {
            isSkinUnlocked = true;
            buttonText.text = "Equip";
            //DisableBuyButton();
        }
    }

    public void OnButtonPress()
    {
        if (isSkinUnlocked)
        {
            //equip
            FindObjectOfType<SkinManager>().EquipSkin(skinInfo);

            ChangeSprite();

        }
        else
        {   //buy
            if (FindObjectOfType<PlayerMoney>().TryRemoveMoney(skinInfo.skinPrice))
            {
                isSkinUnlocked = true;
                PlayerPrefs.SetInt(skinInfo.skinID.ToString(), 1);
                buttonText.text = "Equip";
                audioSource.PlayOneShot(cashRegister);

            }
            else
            {
                NoMoneyAnim.SetTrigger("NoMoney");
                Debug.Log("You don't have enough money!");
            }
        }
    }
    public void ChangeSprite()
    {
        avatarSprite.sprite = SkinManager.equippedSkin;
    }

}
