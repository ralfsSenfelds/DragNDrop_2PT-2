using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour {
	public GameObject atkritumuMasina;
	public GameObject atraPalidziba;
	public GameObject auobuss;
    public GameObject b2;
    public GameObject cement;
    public GameObject e46;
    public GameObject e61;
    public GameObject ex;
    public GameObject police;
    public GameObject tractor1;
    public GameObject tractor2;
    public GameObject firecar;

    [HideInInspector]
	public Vector2 atkrMKoord;
	[HideInInspector]
	public Vector2 atraPKoord;
    [HideInInspector]
    public Vector2 bussKoord;
    [HideInInspector]
    public Vector2 b2Koord;
    [HideInInspector]
    public Vector2 cementKoord;
    [HideInInspector]
    public Vector2 e46Koord;
    [HideInInspector]
    public Vector2 e61Koord;
    [HideInInspector]
    public Vector2 exKoord;
    [HideInInspector]
    public Vector2 policeKoord;
    [HideInInspector]
    public Vector2 tractor1Koord;
    [HideInInspector]
    public Vector2 tractor2Koord;
    [HideInInspector]
    public Vector2 firecarKoord;
    public Canvas kanva;
	public AudioSource audioAvots;
    public AudioClip[] skanasKoAtskanot;
    [HideInInspector]
	public bool vaiIstajaVieta = false;
	public GameObject pedejaisVilktais = null;

    // Use this for initialization
    void Start () {
		atkrMKoord = atkritumuMasina.GetComponent<RectTransform>().localPosition;
        atraPKoord = atraPalidziba.GetComponent<RectTransform>().localPosition;
        bussKoord = auobuss.GetComponent<RectTransform>().localPosition;
        b2Koord = b2.GetComponent<RectTransform>().localPosition;
        cementKoord = cement.GetComponent<RectTransform>().localPosition;
        e46Koord = e46.GetComponent<RectTransform>().localPosition;
        e61Koord = e61.GetComponent<RectTransform>().localPosition;
        exKoord = ex.GetComponent<RectTransform>().localPosition;
        policeKoord = police.GetComponent<RectTransform>().localPosition;
        tractor1Koord = tractor1.GetComponent<RectTransform>().localPosition;
        tractor2Koord = tractor2.GetComponent<RectTransform>().localPosition;
        firecarKoord = firecar.GetComponent<RectTransform>().localPosition;
    }
}
