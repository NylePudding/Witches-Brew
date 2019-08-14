using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Mutator : MonoBehaviour, 
        IPointerClickHandler,
        IDragHandler {

    public Sprite displayArt;
    public string displayName;

    // Use this for initialization
    void Start() {
        transform.Find("Art").GetComponent<Image>().sprite = displayArt;
        transform.Find("TitleText").GetComponent<Text>().text = displayName;
    }


    public void OnPointerClick(PointerEventData eventData) {
    }

    public void OnDrag(PointerEventData eventData) {
        transform.position = Input.mousePosition;
    }


    // Update is called once per frame
    void Update() {

    }
}
