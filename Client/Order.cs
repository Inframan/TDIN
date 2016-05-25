using System;

namespace Client
{
    public class Order
    {
        int quantity;
        DateTime request_date;
        string execution_status;
        string execution_value;
        DateTime execution_date;
        string order_type;
        string company;

        public Order(string q, string rd, string es, string ev, string ed, string ot, string c)
        {
            quantity = Convert.ToInt16(q);
            request_date = Convert.ToDateTime(rd);
            execution_status = es;
            execution_value = ev;
            if(ed != "")
                execution_date = Convert.ToDateTime(ed);
            order_type = ot;
            company = c;
        }

    }
}