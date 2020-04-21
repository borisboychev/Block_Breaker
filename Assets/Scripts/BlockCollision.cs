﻿using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class BlockCollision : MonoBehaviour
{
    [SerializeField]AudioClip blockSFX;
    private GameStatus gameStatus;

    void Start()
    {
        Level.instance.breakableBlocks++;
        gameStatus = FindObjectOfType<GameStatus>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        AudioSource.PlayClipAtPoint(blockSFX , Camera.main.transform.position );
        Destroy(gameObject);
        Level.instance.destroyedBlocks++;
        gameStatus.IncreaseScore();
    }



}
