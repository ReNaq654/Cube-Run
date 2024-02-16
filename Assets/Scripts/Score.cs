using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public Transform player;
    public TMP_Text scoreText;
    float startOffset = 0f;

    private void Start()
    {
        startOffset = player.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = (player.position.z - startOffset).ToString("0");
    }
}
