using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    public Texture2D buttonImage;
    public string labelText = " ";
    private GUIStyle labelStyle;

    private void Start()
    {
        labelStyle = new GUIStyle();
        labelStyle.fontSize = 30;
        labelStyle.normal.textColor = Color.white;
    }
    private void OnGUI()
    {
        GUI.Box(new Rect(0, 0, 1469, 728), "Performance Task: UI Coding");

        if (GUI.Button(new Rect(200, 40, 100, 40), "Player 1"))
        {
            labelText = "Name: Brylle \n\rAttack: 100 \n\rDefence: 50\n\rSpeed: 32\n\rLuck: 62\n\rIntelligence: 88\n\rSpecial: 2";
        }
        if (GUI.Button(new Rect(200, 120, 100, 40), "Player 2"))
        {
            labelText = "Name: Hamilton \n\rAttack: 55 \n\rDefence: 50\n\rSpeed: 30\n\rLuck: 75\n\rIntelligence: 118\n\rSpecial: 3";
        }
        if (GUI.Button(new Rect(200, 200, 100, 40), "Player 3"))
        {
            labelText = "Name: Zack \n\rAttack: 30 \n\rDefence: 50\n\rSpeed: 13\n\rLuck: 48\n\rIntelligence: 83\n\rSpecial: 1";
        }

        GUI.Label(new Rect(700, 100, 500, 500), labelText, labelStyle);

    }
}