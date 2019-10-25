﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDController : MonoBehaviour
{
    public Text HungerText;
    public Text FriendshipText;
    public Text IsSickText;

    public GameObject Rock;

    // Start is called before the first frame update
    void Start()
    {
        /* HungerText.text = "I'm hungry";
        FriendshipText.text = "Hello";
        IsSickText.text = "Healthy"; */
    }

    // Update is called once per frame                                                     
    void Update()
    {
        if (Rock != null)
        {
            HungerText.text = "Hunger: " + Rock.GetComponent<RockController>().hunger.ToString();
            FriendshipText.text = "Friendship: " + Rock.GetComponent<RockController>().friendship.ToString();
            IsSickText.text = "Is sick: " + Rock.GetComponent<RockController>().isSick.ToString();
        }
    }

    public void FeedRock()
    {
        Rock.GetComponent<RockController>().hunger += 2;
    }

    public void PlayWithRock()
    {
        Rock.GetComponent<RockController>().friendship += 2;
    }

    public void GoToVet()
    {
        Rock.GetComponent<RockController>().isSick = false;
    }
}
