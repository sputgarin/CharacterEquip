using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CharacterStatsUI : MonoBehaviour
{
    public TMP_Text IntelligenceLabel;
    public TMP_Text StrengthLabel;
    public CharacterStats Stats;
    
    void Start()
    {
        

    }

    private void OnEnable()
    {
        Stats.IntelligenceChange.AddListener(OnIntelligenceChange);
        Stats.IntelligenceChange.Invoke(0);
        Stats.StrengthChange.AddListener(OnStrengthChange);
        Stats.StrengthChange.Invoke(0);
    }

    private void Awake()
    {
       
        
    }

    private void OnStrengthChange(int newStrength)
    {
        StrengthLabel.text = newStrength.ToString();
    }

    private void OnIntelligenceChange(int newIntelligence)
    {
        IntelligenceLabel.text = newIntelligence.ToString();
    }
}
