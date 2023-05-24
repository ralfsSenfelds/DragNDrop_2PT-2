using System.Collections;
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
        kanvasGrupa = GetComponent<CanvasGroup>();
        velkObjektuRectTransf= GetComponent<RectTransform>();
    }

    public void OnDrag(PointerEventData eventData)
    {
        
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        
    }

    // Use this for initialization
    void Start () {
		
	}
}