using System;
using System.Linq;
using UnityEngine;

namespace UnityEditor.GraphToolsFoundation.Overdrive.Samples.MathBook
{
    [Serializable]
    public class FormBox2PFloat : FormOperator
    {
        public override string Title
        {
            get => "Box 2P (float)";
            set { }
        }

        public override float Evaluate()
        {
            //Point A
            string pointA = Values[0].ToString();
            
            string xPointA = pointA[0].ToString();
            float xA = float.Parse(xPointA);
            string yPointA = pointA[1].ToString();
            float yA = float.Parse(yPointA);
            string zPointA = pointA[2].ToString();
            float zA = float.Parse(zPointA);

            //Point B
            string pointB = Values[1].ToString();
            
            string xPointB = pointB[0].ToString();
            float xB = float.Parse(xPointB);
            string yPointB = pointB[1].ToString();
            float yB = float.Parse(yPointB);
            string zPointB = pointB[2].ToString();
            float zB = float.Parse(zPointB);
            
            //Line 1
            Debug.DrawLine(new Vector3(xA,yA,zA), new Vector3(xB,yA,zA), Color.black, 20);
            //Line 2
            Debug.DrawLine(new Vector3(xB,yA,zA), new Vector3(xB,yA,xB), Color.black, 20);
            //Line 3
            Debug.DrawLine(new Vector3(xB,yA,xB), new Vector3(xA,yA,xB), Color.black, 20);
            //Line 4
            Debug.DrawLine(new Vector3(xA,yA,xB), new Vector3(xA,yA,zA), Color.black, 20);
            
            //Line 5
            Debug.DrawLine(new Vector3(xA,yB,zA), new Vector3(xB,yB,zA), Color.black, 20);
            //Line 6
            Debug.DrawLine(new Vector3(xB,yB,zA), new Vector3(xB,yB,xB), Color.black, 20);
            //Line 7
            Debug.DrawLine(new Vector3(xB,yB,xB), new Vector3(xA,yB,xB), Color.black, 20);
            //Line 8
            Debug.DrawLine(new Vector3(xA,yB,xB), new Vector3(xA,yB,zA), Color.black, 20);
            
            //Line 9
            Debug.DrawLine(new Vector3(xA,yA,zA), new Vector3(xA,yB,zA), Color.black, 20);
            //Line 10
            Debug.DrawLine(new Vector3(xB,yA,zA), new Vector3(xB,yB,zA), Color.black, 20);
            //Line 11
            Debug.DrawLine(new Vector3(xB,yA,xB), new Vector3(xB,yB,xB), Color.black, 20);
            //Line 12
            Debug.DrawLine(new Vector3(xA,yA,xB), new Vector3(xA,yB,xB), Color.black, 20);

            return Values.Last();
        }
        
        protected override void AddInputPorts()
        {
            this.AddDataInputPort<float>("Point A");
            this.AddDataInputPort<float>("Point B");
        }
    }
}
