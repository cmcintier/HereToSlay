using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>();

    public void Awake()
    {
        cardList.Add(new Card(0, "None", 0, 0, "None", Resources.Load<Sprite>("TheFistOfReason")));
        cardList.Add(new Card(1, "Balls", 69, 420, "it's balls", Resources.Load<Sprite>("TheShadowClaw")));
        cardList.Add(new Card(2, "Cock", 69, 420, "it's a cock", Resources.Load<Sprite>("TheDivineArrow")));
        cardList.Add(new Card(3, "Taint", 69, 420, "Grundle", Resources.Load<Sprite>("TheCharismaticSong")));
    }

}
