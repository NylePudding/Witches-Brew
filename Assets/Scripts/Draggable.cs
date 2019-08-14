using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {

    public Transform returningParent = null;
    public Transform placeholderParent = null;
    GameObject placeholder = null;

    public AudioClip pickupSound1;
    public AudioClip pickupSound2;
    public AudioClip pickupSound3;
    public AudioClip pickupSound4;

    public void OnBeginDrag(PointerEventData eventData) {

        placeholder = new GameObject();
        placeholder.transform.SetParent(this.transform.parent);
        LayoutElement le = placeholder.AddComponent<LayoutElement>();
        le.preferredWidth = this.GetComponent<LayoutElement>().preferredWidth;
        le.preferredHeight = this.GetComponent<LayoutElement>().preferredHeight;
        le.flexibleWidth = 0;
        le.flexibleHeight = 0;

        placeholder.transform.SetSiblingIndex(this.transform.GetSiblingIndex());
        returningParent = this.transform.parent;
        this.transform.SetParent(this.transform.root);

        GetComponent<CanvasGroup>().blocksRaycasts = false;

        SoundManager.instance.RandomizeSfx(pickupSound1, pickupSound2, pickupSound3, pickupSound4);


    }

    public void OnDrag(PointerEventData eventData) {

        this.transform.position = eventData.position;

        if (placeholder.transform.parent != placeholderParent)
            placeholder.transform.SetParent(placeholderParent);

        int newSiblingIndex = placeholderParent.childCount;

        for (int i =0; i< placeholderParent.childCount; i++) {
            if (this.transform.position.x < placeholderParent.GetChild(i).position.x) {
                placeholder.transform.SetSiblingIndex(i);

                newSiblingIndex = i;

                if (placeholder.transform.GetSiblingIndex() < newSiblingIndex) {
                    newSiblingIndex--;
                }

                break;
            }
        }

        placeholder.transform.SetSiblingIndex(newSiblingIndex);

    }

    public void OnEndDrag(PointerEventData eventData) {
        this.transform.SetParent(returningParent);
        this.transform.SetSiblingIndex(placeholder.transform.GetSiblingIndex());

        GetComponent<CanvasGroup>().blocksRaycasts = true;

        Destroy(placeholder);
    }
}
