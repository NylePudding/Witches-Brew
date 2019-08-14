using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorManager : MonoBehaviour {

    public GameObject[] Familiars;
    public GameObject[] Ingredients;
    public GameObject[] Locations;

    public static GeneratorManager generatorManager;

	// Use this for initialization
	void Start () {
		if (generatorManager == null) {
            generatorManager = this;
        } else if (generatorManager != this) {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void createRandomIngredient(Transform t) {
        int index = Random.Range(0, Ingredients.Length);

        GameObject card = Instantiate(Ingredients[index],t.position,Quaternion.identity);
        card.transform.SetParent(t.transform);
    }

    public void createRandomFamiliar(Transform t) {
        int index = Random.Range(0, Familiars.Length);

        GameObject card = Instantiate(Familiars[index], t.position, Quaternion.identity);
        card.transform.SetParent(t.transform);
    }

    public void createRandomLocation(Transform t) {
        int index = Random.Range(0, Locations.Length);

        GameObject card = Instantiate(Locations[index], t.position, Quaternion.identity);
        card.transform.SetParent(t.transform);
    }


}
