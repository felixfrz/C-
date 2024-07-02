namespace PropertiesProject
{
    public class Customer
    {
        int? _CustId;
        bool _Status;
        string _CName, _State;
        double _Balance;
        Cities _City;


        public Customer(int CustId, bool Status, string CName, double Balance, Cities City, string State)
        {
            _CustId = CustId;
            _Status = Status;
            _CName = CName;
            _Balance = Balance;
            _City = City;
            _State = State;

        }

        public int? CustId
        {
            get => _CustId;
        }

        public bool Status
        {
            get => _Status;
            set { _Status = value; }
        }

        public string? CName
        {
            get => _CName;
            set
            {
                if (_Status == true)
                {
                    _CName = value;
                }
            }
        }

        public double Balance
        {
            get => _Balance;
            set
            {
                if (_Status == true)
                    if (value >= 500)
                        _Balance = value;
            }
        }

        public Cities City
        {
            get => _City;
            set
            {
                if (_Status == true)
                {
                    _City = value;
                }
            }
        }

        public string State
        {
            get => _State;
            protected set
            {
                if (_Status == true)
                    _State = value;
            }
        }

        // Auto-Implemented or Automatic Property
        //Auto-Property Initializer
        public string Country { get; } = "India";

    }
}

