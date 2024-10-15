using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    public Texture2D buttonImage;
    public string labelText = " ";
    private GUIStyle labelStyle;

    private int attackP1 = 100;
    private int attackP2 = 55;
    private int attackP3 = 30;

    private int defenseP1 = 50;
    private int defenseP2 = 50;
    private int defenseP3 = 50;
    
    private int SpeedP1 = 32;
    private int SpeedP2 = 30;
    private int SpeedP3 = 13;

    private int LuckP1 = 62;
    private int LuckP2 = 75;
    private int LuckP3 = 48;

    private int IntelligenceP1 = 88;
    private int IntelligenceP2 = 118;
    private int IntelligenceP3 = 83;

    private int SpecialP1 = 2;
    private int SpecialP2 = 3;
    private int SpecialP3 = 1;

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
            labelText = "Name: Brylle \n\rAttack: " + attackP1 + "\n\rDefense:" + defenseP1 + "\n\rSpeed: " + SpeedP1 + "\n\rLuck: " + LuckP1 + "\n\rIntelligence: " + IntelligenceP1 + "\n\rSpecial: " + SpecialP1 ;
        }
        if (GUI.Button(new Rect(200, 120, 100, 40), "Player 2"))
        {
            labelText = "Name: Alexis \n\rAttack: " + attackP2 + "\n\rDefense:" + defenseP2 + "\n\rSpeed: " + SpeedP2 + "\n\rLuck: " + LuckP2 + "\n\rIntelligence: " + IntelligenceP2 + "\n\rSpecial: " + SpecialP2;
        }
        if (GUI.Button(new Rect(200, 200, 100, 40), "Player 3"))
        {
            labelText = "Name: Zackery \n\rAttack: " + attackP3 + "\n\rDefense:" + defenseP3 + "\n\rSpeed: " + SpeedP3 + "\n\rLuck: " + LuckP3 + "\n\rIntelligence: " + IntelligenceP3 + "\n\rSpecial: " + SpecialP3;
        }

        GUI.Label(new Rect(700, 100, 500, 500), labelText, labelStyle);

    }
}