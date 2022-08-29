public class Car
{
    //private
    private string[] _brands = new string[] { "BMW", "Toyota", "Tesla" };
    private string[] _name = new string[] {"first", "second", "third"};

    //public indexer
    public string this[int index]
    {
        set { this._brands[index] = value; }
        get { return _brands[index]; }
    }

    public string this[string name]
    {
        set { this._brands[System.Array.IndexOf(_name, name)] = value; }
        get { return _brands[System.Array.IndexOf(_name, name)]; }
    }
}