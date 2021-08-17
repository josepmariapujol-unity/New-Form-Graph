using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class DSSearchWindow : ScriptableObject, ISearchWindowProvider
{
    private GraphViewTool graphViewT;
    public void Initialize(GraphViewTool graphViewTool)
    {
        graphViewT = graphViewTool;
    }
    public List<SearchTreeEntry> CreateSearchTree(SearchWindowContext context)
    {
        List<SearchTreeEntry> searchTreeEntries = new List<SearchTreeEntry>()
        {
            new SearchTreeGroupEntry(new GUIContent("Create Element")),
            new SearchTreeGroupEntry(new GUIContent("Choice 1"),1),
            new SearchTreeEntry(new GUIContent("hola"))
            {
                level = 2,
                userData = new DSNode()
            },
            new SearchTreeGroupEntry(new GUIContent("Choice 2"),1),
            new SearchTreeEntry(new GUIContent("group"))
            {
                level = 2,
                userData = new Group()
            },
        };
        return searchTreeEntries;
    }

    public bool OnSelectEntry(SearchTreeEntry SearchTreeEntry, SearchWindowContext context)
    {
        switch (SearchTreeEntry.userData)
        {
            case DSNode dsNode:
            {
                graphViewT.CreateNode();
                graphViewT.AddElement(dsNode);
                return true;
            }
            case Group _:
            {
                Group group = graphViewT.CreateGroup();
                graphViewT.AddElement(group);
                return true;
            }
            default:
                return false;
        }
    }
}
