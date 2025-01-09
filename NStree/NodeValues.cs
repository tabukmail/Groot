namespace ConsoleApp1;

public class NodeValues
{
    
    private List<int> _values = new List<int>(5){0,0,0,0,0};
    
    
    public List<int> GetValues()
    {
        return _values;
    }
    
    public void SetValues(int index, int value)
    {
        _values[index] = value;
    }
    
}