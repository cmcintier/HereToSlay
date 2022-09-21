using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeck : MonoBehaviour
{

    private Card tempCard = new Card();
    private int x;
    public static int deckSize;
    public List<Card> deck = new List<Card>();
    public static List<Card> staticDeck = new List<Card>();

    public GameObject cardInDeck1;
    public GameObject cardInDeck2;
    public GameObject cardInDeck3;
    public GameObject cardInDeck4;

    public GameObject CardToHand;
    public GameObject[] Clones;
    public GameObject Hand;

    // Start is called before the first frame update
    void Start()
    {
        x = 0;
        deckSize = 40;
        for(int i = 0; i < deckSize; i++)
        {
            x = Random.Range(1, 4);
            deck[i] = CardDatabase.cardList[x];
        }

        staticDeck = deck;
        StartCoroutine(StartGame());
    }

    // Update is called once per frame
    void Update()
    {
        staticDeck = deck;
        if (deckSize < 30)
            cardInDeck1.SetActive(false);
         else
            cardInDeck1.SetActive(true);

        if (deckSize < 20)
            cardInDeck2.SetActive(false);
        else
            cardInDeck2.SetActive(true);

        if (deckSize < 10)
            cardInDeck3.SetActive(false);
        else
            cardInDeck3.SetActive(true);

        if (deckSize <= 0)
            cardInDeck4.SetActive(false);
        else
            cardInDeck4.SetActive(true);
    }

    IEnumerator StartGame()
    {
        for(int i = 0; i < 4; i++)
        {
            yield return new WaitForSeconds(0.1f);
            Instantiate(CardToHand, transform.position, transform.rotation);
        }
    }
    
    
    public void Shuffle()
    {
        for(int i = 0; i < deckSize; i++)
        {
            tempCard = deck[i];
            int randomIndex = Random.Range(i, deckSize);
            deck[i] = deck[randomIndex];
            deck[randomIndex] = tempCard;
        }
    }
}
