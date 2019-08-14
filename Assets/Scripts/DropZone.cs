using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler {

    public CardDefinition.CardType AllowedType;
    public int MaxCards;

    public void OnDrop(PointerEventData eventData) {
        Debug.Log("OnDrop" + gameObject.name);

        Draggable d = eventData.pointerDrag.GetComponent<Draggable>();

        if (d != null && 
            transform.childCount <= MaxCards &&
            (d.transform.GetComponent<CardDefinition>().Type == AllowedType || 
            AllowedType == CardDefinition.CardType.ALL)) {

            d.returningParent = this.transform;
        }


    }

    public void OnPointerEnter(PointerEventData eventData) {

        //Debug.Log("OnPointerEnter");

        if (eventData.pointerDrag == null)
            return;

        Draggable d = eventData.pointerDrag.GetComponent<Draggable>();

        if (d != null) {
            d.placeholderParent = this.transform;
        }


    }


    public void OnPointerExit(PointerEventData eventData) {
        //Debug.Log("OnPointerEnter");

        if (eventData.pointerDrag == null)
            return;

        Draggable d = eventData.pointerDrag.GetComponent<Draggable>();

        if (d != null && d.placeholderParent == this.transform) {
            d.placeholderParent = d.returningParent;
        }
    }
}
