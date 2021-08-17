using System;
using UnityEditor.Experimental.GraphView;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using State = UnityEditor.GraphToolsFoundation.Overdrive;
namespace UnityEditor.GraphToolsFoundation.Overdrive.Samples.MathBook
{
    public class GraphViewWindow : GraphViewEditorWindow
    {
        [MenuItem("Form Graph/Sample")]
        public static void ShowWindow()
        {
            var window = GetWindow<GraphViewWindow>("New FormGraph");
            window.maximized = true;
            window.position = new Rect(0, 0, 1000, 1000);
        }

        private void OnEnable()
        {
            AddGraphView();
        }

        private void AddGraphView()
        {
            GraphViewTool graphViewTool = new GraphViewTool();
            
            graphViewTool.StretchToParentSize();
            
            rootVisualElement.Add(graphViewTool);
        }
    }
}