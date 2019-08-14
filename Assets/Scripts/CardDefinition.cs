using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDefinition : MonoBehaviour {

    public enum CardType { FAMILIAR, LOCATION, INGREDIENT, ALL };
    public CardType Type;
    public string Title;
    public Sprite CardArt;
    public GameObject CardContainer;
    
    // Use this for initialization
	void Start () {

        if (transform.childCount < 1) {

            GameObject cardContainer = Instantiate(CardContainer, transform.position, Quaternion.identity);

            cardContainer.transform.SetParent(transform);

            cardContainer.transform.localScale = new Vector3(1, 1, 1);

            transform.GetChild(0).GetChild(0).GetComponent<Image>().sprite = CardArt;
            transform.GetChild(0).GetChild(1).GetComponent<Text>().text = Title;
            transform.GetChild(0).GetChild(2).GetComponent<Text>().text = getTypeString(Type);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void setArt(Sprite spr) {
        transform.GetChild(0).GetComponent<Image>().sprite = spr;
    }

    string getTypeString(CardType type) {

        switch (type) {
            case CardType.FAMILIAR:
                return "Familiar";
            case CardType.INGREDIENT:
                return "Ingredient";
            case CardType.LOCATION:
                return "Location";
            default:
                return "All";
        }

    }
}
