using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class StarDisplay : MonoBehaviour {

	// Use this for initialization

	[SerializeField] int stars = 100;
	Text starText;
	void Start () {
		starText = GetComponent<Text>();
		UpdateDisplay(); 
	}
	private void UpdateDisplay(){
		starText.text = stars.ToString();
	}

	public bool HaveEnoughStars(int amount){
		return stars >= amount;
	}

	public void AddStars(int amount){
		stars += amount;
		UpdateDisplay();
	}
	
	public void SpendStars(int amount){
		if (stars >= amount){
			stars -= amount;
			UpdateDisplay();
		}
	}
}
