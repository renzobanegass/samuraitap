using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "WinnerPanel", fileName = "WinnerPanel")]
public class WinnerPanel : ScriptableObject
{
    public string Name;

    void Awake()
    {
        Name = "";
    }
}
