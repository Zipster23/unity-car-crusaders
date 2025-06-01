using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System;

public class CollectibleCounter : MonoBehaviour
{
    private TextMeshProUGUI collectibleText;
    // Start is called before the first frame update
    void Start()
    {
        collectibleText = GetComponent<TextMeshProUGUI>();
        if (collectibleText == null)
        {
            Debug.LogError("UpdateCollectibleCount script requires a TextMeshProUGUI component on the same GameObject");
        }
        UpdateCollectibleDisplay();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateCollectibleDisplay();
    }

    private void UpdateCollectibleDisplay()
    {
        int totalCollectibles = 0;

        Type collectibleType = Type.GetType("Collectible");
        if (collectibleType != null)
        {
            totalCollectibles += UnityEngine.Object.FindObjectsOfType(collectibleType).Length;
            collectibleText.text = $"Coins left: {totalCollectibles}";
        }

        if (totalCollectibles == 0)
        {
            collectibleText.color = Color.yellow;
            collectibleText.text = $"You won!";
        }
    }
}
