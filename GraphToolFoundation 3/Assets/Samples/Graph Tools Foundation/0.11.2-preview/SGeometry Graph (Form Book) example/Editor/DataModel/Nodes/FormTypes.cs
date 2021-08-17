using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;
using UnityEngine.GraphToolsFoundation.Overdrive;

namespace UnityEditor.GraphToolsFoundation.Overdrive.Samples.MathBook
{
    [Serializable]
    public class FormTypes : FormNode
    {
        public override string Title
        {
            get => "All Types";
            set { }
        }

        public override float Evaluate()
        {
            return Mathf.Epsilon;
        }

        public override void ResetConnections()
        {
        }

        protected override void OnDefineNode()
        {
            this.AddDataOutputPort<float>("Output");
            this.AddOutputPort("Float",PortType.Data, TypeHandle.Float, null, PortOrientation.Horizontal);
            this.AddOutputPort("Int",PortType.Data, TypeHandle.Int, null, PortOrientation.Horizontal);
            this.AddOutputPort("Bool",PortType.Data, TypeHandle.Bool, null, PortOrientation.Horizontal);
            this.AddOutputPort("Vector2",PortType.Data, TypeHandle.Vector2, null, PortOrientation.Horizontal);
            this.AddOutputPort("Vector3",PortType.Data, TypeHandle.Vector3, null, PortOrientation.Horizontal);
            this.AddOutputPort("Vector4",PortType.Data, TypeHandle.Vector4, null, PortOrientation.Horizontal);
            this.AddOutputPort("Double",PortType.Data, TypeHandle.Double, null, PortOrientation.Horizontal);
            this.AddOutputPort("Long",PortType.Data, TypeHandle.Long, null, PortOrientation.Horizontal);
            this.AddOutputPort("String",PortType.Data, TypeHandle.String, null, PortOrientation.Horizontal);
            this.AddOutputPort("GameObject",PortType.Data, TypeHandle.GameObject, null, PortOrientation.Horizontal);
            this.AddOutputPort("Object",PortType.Data, TypeHandle.Object, null, PortOrientation.Horizontal);
            this.AddOutputPort("UInt",PortType.Data, TypeHandle.UInt, null, PortOrientation.Horizontal);
            this.AddOutputPort("Void",PortType.Data, TypeHandle.Void, null, PortOrientation.Horizontal);
            this.AddOutputPort("Quaternion",PortType.Data, TypeHandle.Quaternion, null, PortOrientation.Horizontal);
            this.AddOutputPort("Char",PortType.Data, TypeHandle.Char, null, PortOrientation.Horizontal);
            this.AddOutputPort("Unknown",PortType.Data, TypeHandle.Unknown, null, PortOrientation.Horizontal);
            this.AddOutputPort("ExecutionFlow",PortType.Data, TypeHandle.ExecutionFlow, null, PortOrientation.Horizontal);
            this.AddOutputPort("MissingPort",PortType.Data, TypeHandle.MissingPort, null, PortOrientation.Horizontal);
            this.AddOutputPort("MissingType",PortType.Data, TypeHandle.MissingType, null, PortOrientation.Horizontal);
        }
    }
}
