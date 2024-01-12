public class Car
{
    //private
    private string[] _brands = new string[] { "BMW", "Honda"};
    private string[] _name = new string[] { "first", "second" };


    //public indexer
    public string this[int index]
    {
        set
        {
            this._brands[index] = value;
        }

        get { 
            return this._brands[index];
        }
    }


    public string this[string name]
    {
        set
        {
            this._brands[Array.IndexOf(this._name, name)] = value;
        }
        get
        {
            return this._brands[Array.IndexOf(this._name, name)];
        }
    }
}