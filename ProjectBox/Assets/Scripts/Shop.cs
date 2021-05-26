using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Shop : MonoBehaviour
{
    #region Singleton:Shop
    public static Shop Instance;
    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }
    #endregion
    [System.Serializable] public class ShopItem
    {
        public Sprite Image;
        public int Price;
        public bool IsPurchased = false;
    }

    public List<ShopItem> ShopItemList;
    [SerializeField] Animator NoMoneyAnim;
    [SerializeField] AudioSource audioSource;

    [SerializeField]GameObject ItemTemplate;
    GameObject g;
    [SerializeField] Transform ShopScrollView;
    [SerializeField] GameObject ShopPanel;
    public Button buyBtn;

    void Start()
    {        
        int len = ShopItemList.Count;
        for (int i = 0; i < len; i++)
        {
            g = Instantiate(ItemTemplate, ShopScrollView);
            g.transform.GetChild(0).GetComponent<Image>().sprite = ShopItemList[i].Image;
            g.transform.GetChild(1).GetChild(0).GetComponent<Text>().text = ShopItemList[i].Price.ToString();
            buyBtn = g.transform.GetChild(2).GetComponent<Button>();
            if (ShopItemList[i].IsPurchased)
            {
                DisableBuyButton();
            }           
            buyBtn.AddEventListener(i, OnShopItemBtnClicked);
        }
        
    }

    //when the "buy" button is clicked
    void OnShopItemBtnClicked(int itemIndex)
    {
        if (Buy.Instance.HasEnoughMoney(ShopItemList[itemIndex].Price))
        {
            Buy.Instance.UseMoney(ShopItemList[itemIndex].Price);
            //purchase Item
            //ShopItemList[itemIndex].IsPurchased = true;

            //disable the button
                //find the button to disable
                //buyBtn = ShopScrollView.GetChild(itemIndex).GetChild(2).GetComponent<Button>();
                //disable it
                DisableBuyButton();

            //play sound
            audioSource.Play();

            //change UI text: money
            Buy.Instance.UpdateMoneyUIText();

            //add skin
            //Profile.Instance.AddSkin(ShopItemList[itemIndex].Image); 
            
        }
        else
        {
            NoMoneyAnim.SetTrigger("NoMoney");
            Debug.Log("You don't have enough money!");
        }
    }

    public void DisableBuyButton()
    {
        buyBtn.interactable = false;
        buyBtn.transform.GetChild(0).GetComponent<Text>().text = "PURCHASED";
    }

   

    //open & close shop
    public void OpenShop()
    {
        ShopPanel.SetActive(true);
    }

    public void CloseShop()
    {
        ShopPanel.SetActive(false);
    }
}
