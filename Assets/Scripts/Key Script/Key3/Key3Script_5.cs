﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key3Script_5 : MonoBehaviour
{
    private ThiefMove thePlayer;

    // Start is called before the first frame update
    void Start()
    {
        thePlayer = FindObjectOfType<ThiefMove>();
        if (thePlayer.getKey3 || thePlayer.randomKey3 != 5)
        {
            gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}