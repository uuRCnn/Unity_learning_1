using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Object = UnityEngine.Object;

public class geriSayımManager : MonoBehaviour
{
    [SerializeField] private GameObject geriSayımObje;
    [SerializeField] private TextMeshProUGUI geriSayımText;
    private GameManager gameManager;

    private void Awake()
    {
        gameManager = Object.FindObjectOfType<GameManager>();
    }

    void Start()
    {
        StartCoroutine(GeriyeSayımRoutine());
    }

    IEnumerator GeriyeSayımRoutine()
    {
        geriSayımText.text = "3";
        yield return new WaitForSeconds(0.5f);
        
        geriSayımObje.GetComponent<RectTransform>().DOScale(1, 0.5f).SetEase(Ease.OutBack);
        yield return new WaitForSeconds(1f);
        geriSayımObje.GetComponent<RectTransform>().DOScale(0, 0.5f).SetEase(Ease.InBack);
        yield return new WaitForSeconds(0.6f);
        
        geriSayımText.text = "2";
        yield return new WaitForSeconds(0.5f);
        
        geriSayımObje.GetComponent<RectTransform>().DOScale(1, 0.5f).SetEase(Ease.OutBack);
        yield return new WaitForSeconds(1f);
        geriSayımObje.GetComponent<RectTransform>().DOScale(0, 0.5f).SetEase(Ease.InBack);
        yield return new WaitForSeconds(0.6f);
        
        geriSayımText.text = "1";
        yield return new WaitForSeconds(0.5f);
        
        geriSayımObje.GetComponent<RectTransform>().DOScale(1, 0.5f).SetEase(Ease.OutBack);
        yield return new WaitForSeconds(1f);
        geriSayımObje.GetComponent<RectTransform>().DOScale(0, 0.5f).SetEase(Ease.InBack);
        yield return new WaitForSeconds(0.6f);
        
        StopAllCoroutines();
        
        gameManager.OyunaBaşla();
        

    }
}