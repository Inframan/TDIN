new Vue({
    el: '#eBanking',
    data: {
        companies: [],
        selected_company: '',
        order_types: [{text: 'Purchase', value: 'Purchase'}, {text: 'Sell', value: 'Sell'}],
        selected_order_type: 'Purchase',
        client_email: '',
        client_name: '',
        quantity: 1,
        orders_from_user: [],
        list_email: '',
        list_name: ''
    },
    ready() {
        this.fetchData();
    },
    methods: {
        fetchData: function () {
            var url = 'http://tempuri.org/IInterBankOps/GetCompanies';
            $.ajax({
                url: url,
                method: 'get',
                dataType: 'jsonp'
            }).success(function (data) {
                console.log(data);
            });
        },
        getOrders: function () {
            var url = 'http://tempuri.org/IInterBankOps/GetCompanies';
            $.ajax({
                url: url,
                method: 'post',
                data: {
                    name: this.list_name,
                    email: this.list_email
                },
                dataType: 'jsonp'
            }).success(function (data) {
                console.log(data);
            });
        },
        submitOrder: function () {
            var url = 'http://tempuri.org/IInterBankOps/GetCompanies';
            $.ajax({
                url: url,
                method: 'post',
                data: {
                    name: this.client_name,
                    email: this.client_email,
                    quantity: this.quantity,
                    company: this.selected_company,
                    type: this.selected_order_type
                },
                dataType: 'jsonp'
            }).success(function (data) {
                console.log(data);
            });
        }
    }
});