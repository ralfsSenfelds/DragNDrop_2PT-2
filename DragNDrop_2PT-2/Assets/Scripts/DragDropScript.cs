﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDropScript : MonoBehaviour,
	IBeginDragHandler, IDragHandler, IEndDragHandler {
    //Uzglabās norādi uz Objektu skriptu
    public Objekti objektuSkripts;
    //Uzglabās norādi uz katra objekta CanvasGroup
    private CanvasGroup kanvasGrupa;
    private RectTransform velkObjektuRectTransf;
    public void OnBeginDrag(PointerEventData eventData)
    {
        objektuSkripts.pedejaisVilktais = null;
        kanvasGrupa.alpha = 0.6f;
        kanvasGrupa.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        velkObjektuRectTransf.anchoredPosition += eventData.delta / objektuSkripts.kanva.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        objektuSkripts.pedejaisVilktais = eventData.pointerDrag;
        kanvasGrupa.alpha = 1f;

        if (objektuSkripts.vaiIstajaVieta == false)
            kanvasGrupa.blocksRaycasts = true;
        else
            objektuSkripts.pedejaisVilktais = null;
        objektuSkripts.vaiIstajaVieta = false;
    }

    // Use this for initialization
    void Start () {
        kanvasGrupa = GetComponent<CanvasGroup>();
        velkObjektuRectTransf = GetComponent<RectTransform>();
    }
}