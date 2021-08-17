using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor.Experimental.GraphView;
using UnityEditor.Graphs;
using UnityEditor.GraphToolsFoundation.Overdrive.BasicModel;
using UnityEditor.GraphToolsFoundation.Searcher;
using UnityEngine;
using UnityEngine.GraphToolsFoundation.Overdrive;

namespace UnityEditor.GraphToolsFoundation.Overdrive.Samples.MathBook
{
    class FormBookStencil : Stencil, ISearcherDatabaseProvider
    {
        List<SearcherDatabaseBase> m_Databases = new List<SearcherDatabaseBase>();

        private GameObject _gameObject;
        public override string ToolName => GraphName;

        public static string GraphName => "Form Book - GraphName";

        public FormBookStencil()
        {
            SearcherItem MakeSearcherItem((Type t, string name) tuple)
            {
                return new GraphNodeModelSearcherItem(GraphModel, null, data => data.CreateNode(tuple.t), tuple.name);
            }
            
            var operators = new[]
                {
                    (typeof(FormExpressionNode), "Expression"),
                    (typeof(FormResult), "Result"),
                    (typeof(FormReset), "Reset"),
                    (typeof(FormAdditionOperator), "Addition"),
                    (typeof(FormMoveOperator), "Move"),
                }
                .Select(MakeSearcherItem);
            
            var operatorsItem = new SearcherItem("1.- Operators", "", operators.ToList());

            var functions = new[]
                {
                    (typeof(SqrtFunction), "Sqrt"),
                    (typeof(RectFunction), "Rect"),
                }
                .Select(MakeSearcherItem);
            
            var functionsItem = new SearcherItem("2.- Functions", "", functions.ToList());

            var constants = new List<SearcherItem>
            {                
                MakeSearcherItem((typeof(FormOrigin), "Origin")),
                MakeSearcherItem((typeof(Constant), "PI")),
                new GraphNodeModelSearcherItem(GraphModel, null,
                    t => t.GraphModel.CreateConstantNode(TypeHandle.Float, "", t.Position, t.Guid, null, t.SpawnFlags),
                    "Float"),   
                new GraphNodeModelSearcherItem(GraphModel, null,
                    t => t.GraphModel.CreateConstantNode(TypeHandle.Int, "", t.Position, t.Guid, null, t.SpawnFlags),
                    "Integer"),   
                new GraphNodeModelSearcherItem(GraphModel, null,
                    t => t.GraphModel.CreateConstantNode(TypeHandle.Bool, "", t.Position, t.Guid, null, t.SpawnFlags),
                    "Bool"),
                new GraphNodeModelSearcherItem(GraphModel, null,
                    t => t.GraphModel.CreateConstantNode(TypeHandle.Vector2, "", t.Position, t.Guid, null, t.SpawnFlags),
                    "Vector2"),
                new GraphNodeModelSearcherItem(GraphModel, null,
                    t => t.GraphModel.CreateConstantNode(TypeHandle.Vector3, "", t.Position, t.Guid, null, t.SpawnFlags),
                    "Vector3"),
                new GraphNodeModelSearcherItem(GraphModel, null,
                    t => t.GraphModel.CreateConstantNode(TypeHandle.Vector4, "", t.Position, t.Guid, null, t.SpawnFlags),
                    "Vector4"),
                new GraphNodeModelSearcherItem(GraphModel, null,
                    t => t.GraphModel.CreateConstantNode(TypeHandle.String, "", t.Position, t.Guid, null, t.SpawnFlags),
                    "String"),
                new GraphNodeModelSearcherItem(GraphModel, null,
                    t => t.GraphModel.CreateConstantNode(TypeHandle.Double, "", t.Position, t.Guid, null, t.SpawnFlags),
                    "Double"),
                new GraphNodeModelSearcherItem(GraphModel, null,
                    t => t.GraphModel.CreateConstantNode(TypeHandle.Long, "", t.Position, t.Guid, null, t.SpawnFlags),
                    "Long"),
                new GraphNodeModelSearcherItem(GraphModel, null,
                    t => t.GraphModel.CreateConstantNode(TypeHandle.GameObject, "", t.Position, t.Guid, v => v.Move(Vector2.down), t.SpawnFlags),
                    "GameObject"),
                    /*
                    t => t.GraphModel.CreateConstantNode(TypeHandle.Object, "", t.Position, t.Guid, null, t.SpawnFlags),
                    "Object"),
                    t => t.GraphModel.CreateConstantNode(TypeHandle.UInt, "", t.Position, t.Guid, null, t.SpawnFlags),
                    "UInt"),
                    t => t.GraphModel.CreateConstantNode(TypeHandle.Void, "", t.Position, t.Guid, null, t.SpawnFlags),
                    "Void"),
                    t => t.GraphModel.CreateConstantNode(TypeHandle.Quaternion, "", t.Position, t.Guid, null, t.SpawnFlags),
                    "Quaternion"),
                    t => t.GraphModel.CreateConstantNode(TypeHandle.Void, "", t.Position, t.Guid, null, t.SpawnFlags),
                    "Void"),
                    t => t.GraphModel.CreateConstantNode(TypeHandle.Char, "", t.Position, t.Guid, null, t.SpawnFlags),
                    "Char"),
                    t => t.GraphModel.CreateConstantNode(TypeHandle.ExecutionFlow, "", t.Position, t.Guid, null, t.SpawnFlags),
                    "Ex"),*/
            };
            
            var constantsItem = new SearcherItem("3.- Numeric", "", constants);

            var instantiate = new[]
                {
                    (typeof(FormVectorFloat), "Vector (Float)"),
                    (typeof(FormPointFloat), "Point (Float)"),
                    (typeof(FormLineFloat), "Line (Float)"),
                    (typeof(FormRectangleFloat), "Rectangle (Float)"), 
                    (typeof(FormBox2PFloat), "Box2P (Float)"),
                    (typeof(FormPyramidFloat), "Pyramid3P (Float)"),
                    (typeof(FormDivide), "Divide (Float)"),
                    (typeof(FormSeriesFloat), "Series (Float)"),
                    (typeof(FormRectangleXYFloat), "Rectangle XY (Float)"), 

                }
                .Select(MakeSearcherItem);
            
            var instantiateItem = new SearcherItem("4.- Instantiate", "", instantiate.ToList());
            
            var others = new[]
                {
                    (typeof(FormTypes), "All Types"),
                    //Add Sticky NodeStickyNote
                }
                .Select(MakeSearcherItem);
            
            var othersItem = new SearcherItem("5.- Others", "", others.ToList());

            
            var items = new List<SearcherItem> { othersItem, operatorsItem, functionsItem, constantsItem, instantiateItem };

            var searcherDatabase = new SearcherDatabase(items);
            m_Databases.Add(searcherDatabase);
        }

        public override Type GetConstantNodeValueType(TypeHandle typeHandle)
        {
            return TypeToConstantMapper.GetConstantNodeType(typeHandle);
        }

        public override ISearcherDatabaseProvider GetSearcherDatabaseProvider()
        {
            return this;
        }

        List<SearcherDatabaseBase> ISearcherDatabaseProvider.GetGraphElementsSearcherDatabases(IGraphModel graphModel)
        {
            return m_Databases;
        }

        List<SearcherDatabaseBase> m_EmptyList = new List<SearcherDatabaseBase>();
        List<SearcherDatabaseBase> ISearcherDatabaseProvider.GetVariableTypesSearcherDatabases()
        {
            return m_EmptyList;
        }

        List<SearcherDatabaseBase> ISearcherDatabaseProvider.GetGraphVariablesSearcherDatabases(IGraphModel graphModel)
        {
            return m_Databases;
        }

        List<SearcherDatabaseBase> ISearcherDatabaseProvider.GetDynamicSearcherDatabases(IPortModel portModel)
        {
            return m_Databases;
        }

        public List<SearcherDatabaseBase> GetDynamicSearcherDatabases(IEnumerable<IPortModel> portModel)
        {
            return m_Databases;
        }

        /// <inheritdoc />
        public override IBlackboardGraphModel CreateBlackboardGraphModel(IGraphAssetModel graphAssetModel)
        {
            return new BlackboardGraphModel(graphAssetModel);
        }

        public override void PopulateBlackboardCreateMenu(string sectionName, GenericMenu menu, CommandDispatcher commandDispatcher)
        {
            menu.AddItem(new GUIContent("Create Variable"), false, () =>
            {
                const string newItemName = "variable";
                var finalName = newItemName;
                var i = 0;
                while (commandDispatcher.State.WindowState.GraphModel.VariableDeclarations.Any(v => v.Title == finalName))
                    finalName = newItemName + i++;

                commandDispatcher.Dispatch(new CreateGraphVariableDeclarationCommand(finalName, true, TypeHandle.Float, typeof(FormBookVariableDeclarationModel)));
            });
        }
    }
}
