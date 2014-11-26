var LandingPageController = function ($scope) {
    $scope.models = {
        helloAngular: 'I work!'
        ,ServerThread: ''
    };

    $scope.searchProducts = function () {
        var result = ProductFactory($scope.productForm.searchName);
        result.then(function (result) {
            if (result.success) {
                if ($scope.productForm.returnUrl !== undefined) {
                    $location.path('/routeOne');
                } else {
                    $location.path($scope.productForm.returnUrl);
                }
            } else {
                $scope.productForm.ReturnCount = 0;
                $scope.productForm.ResultMessage = "Something bad happened.";
            }
        });
    }
}

// The $inject property of every controller 
//(and pretty much every other type of object in Angular) 
//needs to be a string array equal to the controllers arguments, only as strings
LandingPageController.$inject = ['$scope'];