using System;
using System.Collections;
using System.Dynamic;



namespace Treeton;

//TODO 
// 1. DeleteNode() - option to lock node from deletion if it hes NodeValues
// 2. MoveNode()
// 3. IsLeaf()
// 4. CountNodes()
// 5. options to plug-in data source  : JSON or DB option 
// 6. name automation according parents last digit
// DONE - 7. create PrintTree() method after GetTree() method
// DONE - 8. AddValueToNode() create method to add value directly from tree
// DONE - 9. GetValueOf() create method to get value directly from tree by value index.
// 10. options to export(): XLSX, CSV, XML, JSON or DB option 


public class Node : IComparable
{
    private int _parentId;
    private int _id;
    private int _leftKey;
    private int _rightKey;
    private int _level;
    private string _name;
    private NodeValues _nodeValues= new NodeValues();
    private static NodeValueSettings _nodeValueSettings = new NodeValueSettings();
    
    
    

    public int GetParentId() => _parentId;
    public int GetId() => _id;
    public int GetLevel() => _level;
    public string GetName() => _name;
    public void SetName(string name) => _name = name;
    public int GetLeft_Key() => _leftKey;
    private void setLeft_Key(int key) => _leftKey = key;
    public int GetRight_Key() => _rightKey;
    private void setRight_Key(int key) => _rightKey = key;
    public NodeValues GetNodeData() => _nodeValues;
    public NodeValueSettings GetNodeValueSettings() => _nodeValueSettings;
  
   


    private Node(int parentId, int id, int leftKey, int rightKey, int level, string name, NodeValues nodeValues)
    {
        _parentId = parentId;
        _id = id;
        _leftKey = leftKey;
        _rightKey = rightKey;
        _level = level;
        _name = name;
        _nodeValues = nodeValues;
    }
    
    private Node(int parentId, string name)
    {
        _parentId = parentId;
        _name = name;
    }

    private Node(int parentId, int id, int leftKey, int rightKey, int level, string name)
    {
        _parentId = parentId;
        _id = id;
        _leftKey = leftKey;
        _rightKey = rightKey;
        _level = level;
        _name = name;
    }


    public int CompareTo(object? incomingobject) 
    { 
        Node incomingNode = incomingobject as Node ?? throw new InvalidOperationException(); 
        return this._leftKey.CompareTo(incomingNode._leftKey); 
    } 
        
        /// ===================================== nested class Tree ==============================
        public class Root 
        {
                
                private readonly ArrayList _tree = [new Node(0, 1, 1, 2, 0, "root")];

                public ArrayList GetTree() => _tree;
                
                public void AddNode(int parentId, string newNodeName)
                {
                    
                    if ((parentId > _tree.Count) || (parentId  <= 0)){
                        Console.WriteLine($":: -> {parentId } is out of possible range");
                        return;
                    }
                    
                    var lefthKey = 0;
                    var rightKey = 0;
                    var level = 0;
                    var parentRightKey = 0;
                    var parentLefthKey = 0;
                    
                   foreach (Node? node_i in _tree.ToArray())
                    {
                        if (node_i != null && parentId == node_i.GetId())
                        {
                            parentRightKey = node_i.GetRight_Key();
                            parentLefthKey = node_i.GetLeft_Key();
                            lefthKey = node_i.GetRight_Key();
                            rightKey = lefthKey + 1;
                            level = node_i.GetLevel() + 1;
                            node_i.setRight_Key(node_i.GetRight_Key() + 2);
                            
                        }
                    }
                   
                    foreach (Node? node_j in _tree.ToArray())
                    {
                        if (node_j != null && node_j.GetLeft_Key() > parentRightKey)
                        {
                            node_j.setRight_Key(node_j.GetRight_Key() + 2);
                            node_j.setLeft_Key(node_j.GetLeft_Key() + 2);
                        }
                        
                        if (node_j != null && node_j.GetRight_Key() > parentRightKey && node_j.GetLeft_Key() < parentLefthKey)
                        {
                            node_j.setRight_Key(node_j.GetRight_Key() + 2);
                        }
                    }
                   
                    _tree.Add (new Node(parentId, _tree.Count + 1, lefthKey, rightKey, level, newNodeName, new NodeValues()));
                    
                   
                   _tree.Sort();
                        
                   }

                public void AddValueToSpecificNode(string nodeName, int nodeValueIndex, object value)
                {
                    foreach (Node node in _tree)
                    {
                        // if index value is NOT exists
                        if (node.GetName() == nodeName && nodeValueIndex > node.GetNodeData().GetNodeValues().Count -1)
                        {
                           var condition = nodeValueIndex - (node.GetNodeData().GetNodeValues().Count-1) != 1;
                           if (condition)
                           {
                               for (int i = node.GetNodeData().GetNodeValues().Count ; i < nodeValueIndex; i++)
                               {
                                   node.GetNodeData().GetNodeValues().Add(0);
                                   //Console.WriteLine(condition);
                               }
                               
                           }        
                           node.GetNodeData().GetNodeValues().Add(value);
                           
                           break;
                               
                        }
                        
                        // if index value is exists
                        if (node.GetName() == nodeName && node.GetNodeData().GetNodeValues().Count-1 == nodeValueIndex)
                        {
                            node.GetNodeData().GetNodeValues()[nodeValueIndex] = value;
                            break;
                        }
                    }
                }
                
                public void AddValueToSpecificNode2(string nodeName, string nodeValueColumnName, object value)
                {
                    int nodeValueIndex = DictionaryIndexFinder(nodeValueColumnName);
                    //Console.WriteLine($":: -> {nodeValueIndex } ++  {nodeValueColumnName}");
                    
                    
                    bool valueColumnTypeCheck = false;
                    switch (GetNodeValueColumns()[nodeValueColumnName])
                    {
                        case ValueColumnType.String: 
                            valueColumnTypeCheck = value is string;
                            break;
                        case ValueColumnType.Integer:
                            valueColumnTypeCheck = value is int;
                            break;
                        case ValueColumnType.Float:
                            valueColumnTypeCheck = value is float;
                            break;
                        case ValueColumnType.Double:
                            valueColumnTypeCheck = value is double;
                            break;
                        case ValueColumnType.Boolean:
                            valueColumnTypeCheck = value is bool;
                            break;
                        case ValueColumnType.Custom:
                            valueColumnTypeCheck = true;
                            break;
                    }
                    
                    //Console.WriteLine(valueColumnTypeCheck);
                    
                    
                    if (NodeNameFinder(nodeName) && valueColumnTypeCheck)
                    {
                        //Console.WriteLine($":: -> {NodeNameFinder(nodeName)} is out of range");
                        foreach (Node node in _tree)
                        {
                            // if index value is NOT exists
                            if (node.GetName() == nodeName && nodeValueIndex > node.GetNodeData().GetNodeValues().Count -1)
                            {
                                var condition = nodeValueIndex - (node.GetNodeData().GetNodeValues().Count-1) != 1;
                                if (condition)
                                {
                                    for (int i = node.GetNodeData().GetNodeValues().Count ; i < nodeValueIndex; i++)
                                    {
                                        node.GetNodeData().GetNodeValues().Add(0);
                                        //Console.WriteLine(condition);
                                    }
                                   
                                }        
                                node.GetNodeData().GetNodeValues().Add(value);
                                
                                break;
                                   
                            }
                            
                            // if index value is exists
                            if (node.GetName() == nodeName && node.GetNodeData().GetNodeValues().Count > nodeValueIndex)
                            {
                               // Console.WriteLine($":: -> {node.GetNodeData().GetNodeValues()[nodeValueIndex]} -- value --> {value} --- index --> {nodeValueIndex}");
                                node.GetNodeData().GetNodeValues()[nodeValueIndex] = value;
                                break;
                            }
                    
                        }
                    
                    }
                    else
                    {
                        Console.WriteLine($":: ->  Please check {nodeName } node name or it's value column type and value type {value}");
                    }
                    
                }
                
                public object GetValueOfSpecificNode(string nodeName, int valueIndex)
                {
                    
                    object? value = 0;
                    foreach (Node node in _tree)
                    {
                        if (node.GetName() == nodeName && valueIndex <= node.GetNodeData().GetNodeValues().Count-1)
                        {
                            value = node.GetNodeData().GetNodeValues()[valueIndex];
                            //Console.WriteLine(value);
                        } else if ((node.GetName() == nodeName && valueIndex > node.GetNodeData().GetNodeValues().Count-1))
                        {
                            Console.WriteLine("ther is no value on this index");
                            value = false;
                        }
                       
                    }

                    return value!;
                }
                
                public object GetValueOfSpecificNode2(string nodeName, string nodeValueColumnName)
                {
                    int nodeValueIndex = DictionaryIndexFinder(nodeValueColumnName);
                    object? value = 0;
                    foreach (Node node in _tree)
                    {
                        if (node.GetName() == nodeName && nodeValueIndex <= node.GetNodeData().GetNodeValues().Count-1)
                        {
                            value = node.GetNodeData().GetNodeValues()[nodeValueIndex];
                            //Console.WriteLine(value);
                        } else if ((node.GetName() == nodeName && nodeValueIndex > node.GetNodeData().GetNodeValues().Count-1))
                        {
                            Console.WriteLine("ther is no value on this index");
                            value = false;
                        }
                       
                    }

                    return value!;
                }
                
                public string PrintAllValuesOfNode(string nodeName)
                {
                    string value = "";
                    foreach (Node node in _tree)
                    {
                        if (node.GetName() == nodeName)
                        {
                              var nodeValues = node.GetNodeData()?.GetNodeValues();
                              if (nodeValues != null)
                              {
                                  value = string.Join(", ", nodeValues.ToArray().Select(item => item?.ToString()));
                              }
                              else
                              {
                                  value = "No values found for this node.";
                              }
                        break; 
                        }
                        
                    }
                    
                    return value;
                }
               
                public ArrayList GetAllValuesOfNode(string nodeName)
                {
                    ArrayList values = new ArrayList();
                    foreach (Node node in _tree)
                    {
                        if (node.GetName() == nodeName)
                        {
                            var nodeValues = node.GetNodeData()?.GetNodeValues();
                            if (nodeValues != null)
                            {
                                values = nodeValues;
                            }
                            else
                            {
                                Console.WriteLine("No values found for this node.");
                            }
                        }
                        
                    }

                    return values;
                }
                
                public void SetUpNodeValueColumn(string name, ValueColumnType valueColumnType)
                {
                   _nodeValueSettings.SetValueType(name, valueColumnType);
                }
                
                public Dictionary<string,ValueColumnType> GetNodeValueColumns()
                { 
                    
                    //string data = string.Join(", ", _nodeValueSettings.GetValueTypes().Select(kvp => $"{kvp.Key}: {kvp.Value}"));
                    return _nodeValueSettings.GetValueTypes()  ;
                
                }
                
                public void PrintTree()
                {
                    foreach (Node node in _tree)
                    {
                        Console.WriteLine(string.Join(", ", node._parentId, node._id, node._leftKey, node._rightKey,
                            node._name, " == > ", PrintAllValuesOfNode(node._name)));
                    }
                    
                }
                
                private  int DictionaryIndexFinder(string key)
                {
                    int counter = 0;
                    if (GetNodeValueColumns().ContainsKey(key) is false)
                    {
                        counter = -1;
                        
                    }else
                    { 
                    foreach (var data in GetNodeValueColumns())
                    {
                        if (data.Key.Equals(key))
                        {
                           break;
                        }
                        counter++;
                    }
                    }
                    
                    return counter;
                }

                private bool NodeNameFinder(string name)
                {
                    foreach (Node? node in _tree.ToArray())
                    {
                        if (node?.GetName() == name)
                        {
                            return true;
                        }
                    }
                    return false;
                    
                }
                
                
                
        }


}

