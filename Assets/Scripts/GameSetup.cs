using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSetup : MonoBehaviour {

    public GameObject Card;
    private GameObject ExploreDropZone;

	// Use this for initialization
	void Start () {
        //ExploreDropZone = GameObject.FindGameObjectWithTag("Dropzone");

    }

    // Update is called once per frame
    void Update () {
		
	}

    public void Setup() {
        
        //GameObject card = Instantiate(Card, transform.position, Quaternion.identity);

        //CardDefinition cardDef = card.GetComponent<CardDefinition>();

        //cardDef.Type = CardDefinition.CardType.FAMILIAR;
        //Sprite sprite = Resources.Load<Sprite>("Assets/Sprites/cat");
        //cardDef.setArt(sprite);
       // cardDef.CardArt = sprite;
        //cardDef.Title = "Black Cat";

        //card.transform.SetParent(GameObject.Find("Inventory").transform);

        Transform inventory = GameObject.Find("Inventory").transform;



        GeneratorManager.generatorManager.createRandomFamiliar(inventory);
        GeneratorManager.generatorManager.createRandomIngredient(inventory);
        GeneratorManager.generatorManager.createRandomLocation(inventory);


    }
}
