new Vue({
    el: '#eBanking',
    data: {
        companies: [],
        selected_company: '',
        order_types: [{text: 'Purchase', value: 'purchase'}, {text: 'Sell', value: 'sell'}],
        selected_order_type: 'purchase',
        client_email: '',
        client_name: '',
        quantity: 1
    },
    ready() {
        this.fetchData();
    },
    methods: {
        fetchData: function () {
            var url = 'http://tempuri.org/IInterBankOps/GetCompanies';
            $.ajax({
                url: 'http://localhost:8733/Design_Time_Addresses/InterBank/?singleWsdl',
                method: 'get',
                dataType: 'jsonp'
            }).success(function (data) {
                console.log(data);
            });
        }
    }
});