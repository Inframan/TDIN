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
        orders: [],
        list_email: '',
        list_name: ''
    },
    ready() {
        this.fetchData();
    },
    methods: {
        fetchData: function () {
            var url = 'http://localhost:56173/RestService.svc/companies';
            $.ajax({
                url: url,
                method: 'get',
                dataType: 'json',
                success: this.setCompanies
            }).error(function () {
                console.log("error");
            });
        },
        setCompanies: function (data) {
            for (var i = 0; i < data.length; i++) {
                this.companies.push({ text: "" + data[i], value: "" + data[i] });
            }
        },
        getOrders: function (event) {
            event.preventDefault();

            var url = 'http://localhost:56173/RestService.svc/orders/name=' + this.list_name + '/mail=' + this.list_email;
            $.ajax({
                url: url,
                method: 'get',
                dataType: 'json',
                success: this.setOrders
            }).error(function () {
                console.log("error");
            });
        },
        setOrders: function (data) {
            for (var i = 0; i < data.length; i++) {
                this.orders.push({
                    type: data[i][5],
                    quantity: data[i][0],
                    value: data[i][3],
                    company: data[i][6],
                    request_date: data[i][1],
                    status: data[i][2],
                    execution_date: data[i][4]
                })
            }
        },
        submitOrder: function (event) {
            event.preventDefault();

            var url = 'http://localhost:56173/RestService.svc/purchaseStock';
            $.ajax({
                url: url,
                method: 'post',
                contentType: "application/json; charset=utf-8",
                data: JSON.stringify({
                    company: this.selected_company,
                    email: this.client_email,
                    execution_value: "",
                    order_type: this.selected_order_type,
                    quantity: this.quantity,
                    username: this.client_name
                }),
                success: this.cleanFormOrder
            }).error(function (data) {
                console.log(data);
            });
        },
        cleanFormOrder: function (data) {
            this.selected_company = "";
            this.client_email = "";
            this.selected_order_type = "Purchase"
            this.quantity = 1,
            this.client_name = "";
        }

    }
});