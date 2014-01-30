using UnityEngine;
using System.Collections;

public class Card : MonoBehaviour {
	
	public string cardName;
	public int energyCost;
	public int planarCost;
	
	public bool Play() {
		this.gameObject.transform.Translate(new Vector3(0, 0, 1.75f));
		return true;
	}
	
	public void DidTapOnCard() {
		Debug.Log("Tony");
	}
}
