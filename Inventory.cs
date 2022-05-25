using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Inventory : MonoBehaviour
{
    [SerializeField] GameObject ui;
    [SerializeField] Vector3 punchForce;
    [SerializeField] float movePosition;
    GameObject[] inventoryImages = new GameObject[5];

    [NonSerialized] public bool handsBusy;
    [NonSerialized] public bool canUseHoe;
    public static Inventory invScript;
    [NonSerialized] public int wheats;

    [NonSerialized] private bool haveShovel;
    [NonSerialized] private bool haveHoe;
    [NonSerialized] private bool haveFlower;
    [NonSerialized] private bool haveCurchKey;
    [NonSerialized] public bool haveSkull_1;

    public bool HaveShovel { get => haveShovel; }
    public bool HaveHoe { get => haveHoe; }
    public bool HaveFlower { get => haveFlower; }
    public bool HaveCurchKey { get => haveCurchKey; }

    [SerializeField] RectTransform ShovelPosi;
    [SerializeField] RectTransform HoePosi;
    [SerializeField] RectTransform FlowerPosi;
    [SerializeField] RectTransform KeyPosi;
    [SerializeField] RectTransform WheatPosi;

    #region Singleton
    private void Awake()
    {
        invScript = this;
    }
    #endregion

    private void Start()
    {
        wheats = 0;
        for (int i = 0; i < ui.transform.childCount; i++)
        {
            inventoryImages[i] = ui.transform.GetChild(i).gameObject;
            inventoryImages[i].gameObject.SetActive(false);
        }
    }
    public void HaveShovel_()
    {
        haveShovel = true;
        inventoryImages[0].SetActive(true);
        inventoryImages[0].GetComponent<RectTransform>().DOMoveY(ShovelPosi.position.y, 0.5f);
        //inventoryImages[0].transform.DOPunchPosition(punchForce, 1.5f, 10, 0.2f);
    }
    public void HaveHoe_()
    {
        haveHoe = true;
        inventoryImages[1].SetActive(true);
        inventoryImages[1].transform.DOMoveY(HoePosi.position.y, 0.5f);
        //inventoryImages[1].transform.DOPunchPosition(punchForce, 1.5f, 10, 0.2f);
    }
    public void HaveFlower_()
    {
        haveFlower = true;
        inventoryImages[2].SetActive(true);
        inventoryImages[2].transform.DOMoveY(FlowerPosi.position.y, 0.5f);
        //inventoryImages[2].transform.DOPunchPosition(punchForce, 1.5f, 10, 0.2f);
    }
    public void HaveCurchKey_()
    {
        haveCurchKey = true;
        inventoryImages[3].SetActive(true);
        inventoryImages[3].transform.DOMoveY(KeyPosi.position.y, 0.5f);
        //inventoryImages[3].transform.DOPunchPosition(punchForce, 1.5f, 10, 0.2f);
    }
    public void HaveWheats_()
    {      
        inventoryImages[4].SetActive(true);
        if (wheats < 1)
        {
            inventoryImages[4].transform.DOMoveY(WheatPosi.position.y, 0.5f);
            //inventoryImages[4].transform.DOPunchPosition(punchForce, 1.5f, 10, 0.2f, true);
        }
        wheats += 1;
    }
}
