using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;



public class Card : MonoBehaviour, 
       IPointerClickHandler,
       IDragHandler {

    public Sprite displayArt;
    public string displayName;

    // Use this for initialization
    void Start () {
        transform.Find("Art").GetComponent<Image>().sprite = displayArt;
        transform.Find("TitleText").GetComponent<Text>().text = displayName;
	}


    public void OnPointerClick(PointerEventData eventData) {
    }

    public void OnDrag(PointerEventData eventData) {
        transform.position = Input.mousePosition;
    }

    // when the GameObjects collider arrange for this GameObject to travel to the left of the screen
    void OnCollisionEnter2D(Collision2D collision) { 
        Debug.Log(collision.gameObject.name + " : " + gameObject.name + " : " + Time.time);
    }


    // Update is called once per frame
    void Update() {

    }
}
