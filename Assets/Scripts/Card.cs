﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Card
{
    public int id;
    public string cardName;
    public int cost;
    public int power;
    public string cardDescription;
    public Sprite spriteImage;

    public Card(){}

    public Card(int id, string cardName, int cost, int power, string cardDescription, Sprite spriteImage)
    {
        this.id = id;
        this.cardName = cardName;
        this.cost = cost;
        this.power = power;
        this.cardDescription = cardDescription;
        this.spriteImage = spriteImage;
    }
}
