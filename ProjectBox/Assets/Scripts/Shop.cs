using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Shop : MonoBehaviour
{
    [System.Serializable] class ShopItem
    {
        public Sprite Image;
        public int Price;
        public bool IsPurchased = false;
    }

    [SerializeField] List<ShopItem> ShopItemList;
    [SerializeField] Animator NoMoneyAnim;
    [SerializeField] Text MoneyText;

    GameObject ItemTemplate;
    GameObject si;
    [SerializeField] Transform ShopScrollView;
    Button buyBtn;

    void Start()
    {
        ItemTemplate = ShopScrollView.GetChild(0).gameObject;

        int len = ShopItemList.Count;
        for (int i = 0; i < len; i++)
        {
            si = Instantiate(ItemTemplate, ShopScrollView);
            si.transform.GetChild(0).GetComponent<Image>().sprite = ShopItemList[i].Image;
            si.transform.GetChild(1).GetChild(0).GetComponent<Text>().text = ShopItemList[i].Price.ToString();
            buyBtn = si.transform.GetChild(2).GetComponent<Button>();
            buyBtn.interactable = !ShopItemList[i].IsPurchased;
            buyBtn.AddEventListener(i, OnShopItemBtnClicked);

        }

        Destroy(ItemTemplate);
    }

    void OnShopItemBtnClicked(int itemIndex)
    {
        if (Buy.Instance.HasEnoughMoney(ShopItemList[itemIndex].Price))
        {
            Buy.Instance.UseMoney(ShopItemList[itemIndex].Price);
            //purchase Item
            ShopItemList[itemIndex].IsPurchased = true;

            //disable the button
            buyBtn = ShopScrollView.GetChild(itemIndex).GetChild(2).GetComponent<Button>();
            buyBtn.interactable = false;
            buyBtn.transform.GetChild(0).GetComponent<Text>().text = "PURCHASED";

            //change UI text: money
            Buy.Instance.UpdateMoneyUIText();
        }
        else
        {
            NoMoneyAnim.SetTrigger("NoMoney");
            Debug.Log("You don't have enough money!");
        }
    }

   

    //open & close shop
    public void OpenShop()
    {
        gameObject.SetActive(true);
    }

    public void CloseShop()
    {
        gameObject.SetActive(false);
    }
}
