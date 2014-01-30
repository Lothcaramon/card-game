using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class CardContainer : MonoBehaviour {

	public int maxCards;
	public int minCards;
	public List<Card> cards;
	
	public void Shuffle() {
		
	}
	
	public void isEmpty() {
		
	}
	
	void Start() {
		cards[0].Play();
	}
}
