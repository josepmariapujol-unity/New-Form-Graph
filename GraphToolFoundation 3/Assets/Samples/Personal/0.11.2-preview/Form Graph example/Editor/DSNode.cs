using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class DSNode : Node
{
    public string DialogueName { get; set; }

    public string Text { get; set; }

    public void Initialize()
    {
        DialogueName = "Name";

        Text = "Dialogue Text...";
    }
}
