using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;

public class GraphViewTool : GraphView
{
    private DSSearchWindow searchWindow;
    public GraphViewTool()
    {
        AddBackground();
        AddManipulators();

        AddSearchWindow();
    }
    

    private void AddManipulators()
    {
        this.AddManipulator(CreateNodeContextualMenu());
        
        SetupZoom(ContentZoomer.DefaultMinScale, ContentZoomer.DefaultMaxScale);
        this.AddManipulator(new ContentDragger());
        this.AddManipulator(new SelectionDragger());
        this.AddManipulator(new RectangleSelector());
        this.AddManipulator(new FreehandSelector());
        this.AddManipulator(new ContentZoomer());
    }

    private IManipulator CreateNodeContextualMenu()
    {
        ContextualMenuManipulator contextualMenuManipulator = new ContextualMenuManipulator(
            menuEvent => menuEvent.menu.AppendAction("Add Node", actionEvent => AddElement(CreateNode())));
        return contextualMenuManipulator;
    }
    public Group CreateGroup()
    {
        Group group = new Group()
        {
            title = "hola"
        };

        return group;
    }
    public DSNode CreateNode()
    {
        DSNode node = new DSNode()        
        {
            title = "Title"
        };
        var text = new Label("Node 1");
        
        node.mainContainer.Add(text);
        node.Initialize();
        return node;
    }
    
    private void AddSearchWindow()
    {
        if (searchWindow == null)
        {
            searchWindow = ScriptableObject.CreateInstance<DSSearchWindow>();
            
            searchWindow.Initialize(this);
        }

        nodeCreationRequest = context => SearchWindow.Open(new SearchWindowContext(context.screenMousePosition), searchWindow);
    }
    
    public void AddBackground()
    {
        GridBackground gridBackground = new GridBackground();
        gridBackground.StretchToParentSize();
        Insert(0, gridBackground);
    }
}
