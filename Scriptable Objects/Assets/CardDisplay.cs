using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour {

	public Card card;
	public Text type;
	public Text nameText;
	public Text descriptionText;

	public Image artworkImage;
	public List<Image> starLevels;
	public Text attackText;
	public Text defenceText;
	private int currStarLevel;
    // Use this for initialization
    private void Start()
    {
		currStarLevel = card.starLevel;
    }
    void Update () {
		nameText.text = card.name;
		descriptionText.text = card.description;

		artworkImage.sprite = card.artwork;

		type.text = "[ " + card.type + " ]";
		attackText.text = "ATK/" + card.attack.ToString();
		defenceText.text = "DEF/" + card.defence.ToString();
	
        if (currStarLevel == card.starLevel)
        {
			for (int i = 0; i < card.starLevel; i++)
			{
				starLevels[i].gameObject.SetActive(true);
			}
		}
        else
        {
			for (int i = 0; i < 5; i++)
			{
				starLevels[i].gameObject.SetActive(false);
			}
		}
		currStarLevel = card.starLevel;
	}
	
}
