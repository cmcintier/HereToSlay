using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DisplayCard : MonoBehaviour
{
    private Card displayCard = new Card();
    public int displayId;

    public int id;
    public string cardName;
    public int cost;
    public int power;
    public string cardDescription;

    public Sprite spriteImage;
    public GameObject cardBackObject;
    public Text nameText;
    public Text costText;
    public Text powerText;
    public Text descriptionText;
    public Image artImage;

    public bool cardBack;

    public GameObject Hand;
    public int numberOfCardsInDeck;

    
    // Start is called before the first frame update
    void Start()
    {
        numberOfCardsInDeck = PlayerDeck.deckSize;

        if (this.tag == "CardToHand")
        {
            displayCard = PlayerDeck.staticDeck[numberOfCardsInDeck - 1];
            numberOfCardsInDeck -= 1;
            PlayerDeck.deckSize -= 1;
            cardBack = false;

            this.transform.SetParent(Hand.transform);
            this.transform.localScale = Vector3.one;
            this.transform.position = new Vector3(transform.position.x, transform.position.y, -48);
            this.transform.eulerAngles = new Vector3(0, 0, 0);

            this.tag = "Untagged";
        }

        id = displayCard.id;
        cardName = displayCard.cardName;
        cost = displayCard.cost;
        power = displayCard.power;
        cardDescription = displayCard.cardDescription;
        spriteImage = displayCard.spriteImage;

        nameText.text = " " + cardName;
        costText.text = " " + cost;
        powerText.text = " " + power;
        descriptionText.text = " " + cardDescription;
        artImage.sprite = spriteImage;

    }

    // Update is called once per frame
    void Update()
    {

        Hand = GameObject.Find("Hand");
        if(this.transform.parent == Hand.transform.parent)
        {
            cardBack = false;
        }

        cardBackObject.SetActive(cardBack);

    }


}
