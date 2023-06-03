using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropPlace : MonoBehaviour, IDropHandler {
	private float vietasZRot, velkObjZRot, rotacijasStarpiba;
	private Vector2 vietasIzm, velkObjIzm;
	private float xIzmeruStarp, yIzmeruStarp;
	public Objekti objektuSkripts;

    public void OnDrop(PointerEventData eventData)
    {
        if(eventData.pointerDrag != null)
        {
            if(eventData.pointerDrag.tag.Equals(tag))
            {
                vietasZRot = GetComponent<RectTransform>().transform.eulerAngles.z;
                velkObjZRot = eventData.pointerDrag.GetComponent<RectTransform>().transform.eulerAngles.z;
                rotacijasStarpiba = Mathf.Abs(velkObjZRot - vietasZRot);
                velkObjIzm = eventData.pointerDrag.GetComponent<RectTransform>().localScale;
                vietasIzm = GetComponent<RectTransform>().localScale;
                
                xIzmeruStarp = Mathf.Abs(velkObjIzm.x - vietasIzm.x);
                yIzmeruStarp = Mathf.Abs(velkObjIzm.y - vietasIzm.y);
               
                if ((rotacijasStarpiba <= 6 || (rotacijasStarpiba >= 354 && rotacijasStarpiba <= 360)) && (xIzmeruStarp <= 0.1 && yIzmeruStarp <= 0.1))
                {
                    objektuSkripts.vaiIstajaVieta = true;
                    eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
                    eventData.pointerDrag.GetComponent<RectTransform>().localRotation = GetComponent<RectTransform>().localRotation;
                    eventData.pointerDrag.GetComponent<RectTransform>().localScale= GetComponent<RectTransform>().localScale;

                    switch (eventData.pointerDrag.tag)
                    {
                        case "atkritumi":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[1]);
                            break;
                        case "medicina":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[2]);
                            break;
                        case "buss":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[3]);
                            break;
                    }      
                }
            }
            else
            {
                objektuSkripts.vaiIstajaVieta = false;
                objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[0]);
                switch (eventData.pointerDrag.tag)
                {
                    case "atkritumi":
                        objektuSkripts.atkritumuMasina.GetComponent<RectTransform>().localPosition = objektuSkripts.atkrMKoord;
                        break;
                    case "medicina":
                        objektuSkripts.atraPalidziba.GetComponent<RectTransform>().localPosition = objektuSkripts.atraPKoord;
                        break;
                    case "buss":
                        objektuSkripts.auobuss.GetComponent<RectTransform>().localPosition = objektuSkripts.bussKoord;
                        break;
                    case "b2":
                        objektuSkripts.auobuss.GetComponent<RectTransform>().localPosition = objektuSkripts.bussKoord;
                        break;
                    case "cement":
                        objektuSkripts.auobuss.GetComponent<RectTransform>().localPosition = objektuSkripts.bussKoord;
                        break;
                    case "e46":
                        objektuSkripts.auobuss.GetComponent<RectTransform>().localPosition = objektuSkripts.bussKoord;
                        break;
                    case "e61":
                        objektuSkripts.auobuss.GetComponent<RectTransform>().localPosition = objektuSkripts.bussKoord;
                        break;
                    case "excavator":
                        objektuSkripts.auobuss.GetComponent<RectTransform>().localPosition = objektuSkripts.bussKoord;
                        break;
                    case "police":
                        objektuSkripts.auobuss.GetComponent<RectTransform>().localPosition = objektuSkripts.bussKoord;
                        break;
                    case "tractor1":
                        objektuSkripts.auobuss.GetComponent<RectTransform>().localPosition = objektuSkripts.bussKoord;
                        break;
                    case "tractor2":
                        objektuSkripts.auobuss.GetComponent<RectTransform>().localPosition = objektuSkripts.bussKoord;
                        break;
                    case "firecar":
                        objektuSkripts.auobuss.GetComponent<RectTransform>().localPosition = objektuSkripts.bussKoord;
                        break;
                }
            }
        }
    }
}