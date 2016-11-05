var app = angular.module("formBasics", []);

app.controller("FormCtrl", function ($scope, $http) {

    $scope.user = {
        email: "",
        password: "",
        confirm: "",
    };

    $scope.formSubmit = function (event) {
        console.log("clicked!");

        console.log($("#angularForm > input"));
        $scope.user.email = $("#angularForm input[name=email]").val();
        $scope.user.password = $("#angularForm input[name=password]").val();
        $scope.user.confirm = $("#angularForm  input[name=confirm]").val();

        $http({
            method: "POST",
            url: "/api/AngularApi",
            data: $scope.user
        }).then(function (response) {
            console.log("it workded");
            console.log(JSON.stringify($scope.user))
        }, function (error) {
            console.log("failed");
        });

        event.preventDefault();
    };
})