// /ng-modules/render-index.js
angular
    .module("homeIndex", ["ngRoute"])
    .config(config)
    .controller("homeController", homeController)
    .controller("aboutController", aboutController);

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

function homeController() {
    var vm = this;
    vm.title = "Home Page";
};

function aboutController() {
    var vm = this;
    vm.title = "About Us";
};