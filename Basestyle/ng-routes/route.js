angular
    .module("homeIndex")
    .config(config);
function config($routeProvider) {
    $routeProvider
        .when("/", {
            templateUrl: "/ng-templates/homeView.html",
            controller: "homeController",
            controllerAs: "vm"
        })
        .when("/about", {
            templateUrl: "/ng-templates/aboutView.html",
            controller: "aboutController",
            controllerAs: "vm"
        })
        .otherwise({ redirectTo: "/" });
};