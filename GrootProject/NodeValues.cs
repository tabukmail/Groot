using System;
using System.Collections;
using System.Collections.Generic;

namespace Groot;

public class NodeValues
{
    //TODO 
    // 1. Agregate values according to the tree 
    // 2. Change List to ArrayList and make it possible to to choose type of value by index[] in a Tree Class constructor
    // 3. possibility to add NUMERICAL values to node_values if IsLeaf() is TRUE
    // 4. possibility to add STRING and CHAR values to node_values.
    // 5. split tree and agregate separately
    // 6. the print() method of the node values for the node 
    //xxx
    
    
    private ArrayList _values = new ArrayList (5){0,0,0,0,0};
    private ArrayList _types = new ArrayList(5){0,0,0,0,0};
    
    
    
    

    public  ArrayList GetValues()
    {
        return _values;
    }
    
    public void SetValues(int index, int value)
    {
        _values[index] = value;
    }
    
    
}