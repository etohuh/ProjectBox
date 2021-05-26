using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Profile : MonoBehaviour
{
    #region Singleton:Profile
    public static Profile Instance;
    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }
    #endregion  

    public class Skin
    {
        public Sprite Image;

    }

    public List<Skin> SkinList;

    [SerializeField] GameObject SkinUITemplate;
    [SerializeField] Transform SkinScrollView;

    GameObject g;
    int newSelectedIndex, previousSelectedIndex = 0;

    [SerializeField] Color ActiveSkinColor;
    [SerializeField] Color DefaultSkinColor;

    [SerializeField] Image CurrentSkin;
    private void Start()
    {
        GetAvailableSkins();
        newSelectedIndex = previousSelectedIndex = 0;
    }

    void GetAvailableSkins()
    {
        for (int i = 0; i < Shop.Instance.ShopItemList.Count; i++)
        {
            if (Shop.Instance.ShopItemList[i].IsPurchased)
            {
                //add all purchased skins to SkinList
                AddSkin(Shop.Instance.ShopItemList[i].Image);
            }
        }

        SelectSkin(newSelectedIndex);
    }

    public void AddSkin (Sprite img)
    {
        if (SkinList == null)
            SkinList = new List<Skin>();

        Skin sk = new Skin() { Image = img };
        //add sk to SkinList
        SkinList.Add(sk);

        //add skin to the UI scroll view
        g = Instantiate(SkinUITemplate, SkinScrollView);
        g.transform.GetChild(0).GetComponent<Image>().sprite = sk.Image;

        //add click event
        g.transform.GetComponent<Button>().AddEventListener(SkinList.Count -1, OnSkinClick);
    }

    void OnSkinClick(int SkinIndex)
    {
        SelectSkin(SkinIndex);
    }

    public void SelectSkin(int SkinIndex)
    {
        previousSelectedIndex = newSelectedIndex;
        newSelectedIndex = SkinIndex;
        SkinScrollView.GetChild(previousSelectedIndex).GetComponent<Image>().color = DefaultSkinColor ;
        SkinScrollView.GetChild(newSelectedIndex).GetComponent<Image>().color = ActiveSkinColor ;

        //Change skin

        CurrentSkin.sprite = SkinList[newSelectedIndex].Image;        
    
    }
  
}
