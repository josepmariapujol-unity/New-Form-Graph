using System;
using System.Linq;
using UnityEngine;

namespace UnityEditor.GraphToolsFoundation.Overdrive.Samples.MathBook
{
    [Serializable]
    public class FormDivide : FormOperator
    {
        public override string Title
        {
            get => "Divide (float)";
            set { }
        }

        public override float Evaluate()
        {
            //Line
            string pointAB = Values[0].ToString();
            
            string xPointA = pointAB[0].ToString();
            float xA = float.Parse(xPointA);
            string yPointA = pointAB[1].ToString();
            float yA = float.Parse(yPointA);
            string zPointA = pointAB[2].ToString();
            float zA = float.Parse(zPointA);

            string xPointB = pointAB[3].ToString();
            float xB = float.Parse(xPointB);
            string yPointB = pointAB[4].ToString();
            float yB = float.Parse(yPointB);
            string zPointB = pointAB[5].ToString();
            float zB = float.Parse(zPointB);

            float pasX = (xA - xB) / (Values[1] + 1);
            float pasY = (xA - xB) / (Values[1] + 1);
            float pasZ = (xA - xB) / (Values[1] + 1);

            string stringValuesDivide = "";

            for (int i = 0; i < Values[1]; i++)
            {
                string xI = (xB + pasX).ToString();
                string yI = (yB + pasY).ToString();
                string zI = (zB + pasZ).ToString();
                stringValuesDivide = xI + yI + zI;
            }
            
            var stringValues = xA.ToString() + yA.ToString() + zA.ToString() + xB.ToString() + yB.ToString() + zB.ToString() + stringValuesDivide;
            Debug.Log(stringValues + " " + stringValues.Length);
            return float.Parse(stringValues);
        }

        protected override void AddInputPorts()
        {
            this.AddDataInputPort<float>("Line");
            this.AddDataInputPort<float>("Times");
        }
    }
}