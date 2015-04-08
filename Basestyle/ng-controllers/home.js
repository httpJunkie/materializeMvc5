angular
    .module("homeIndex")
    .controller("homeController", homeController);

function homeController() {
    var vm = this;
    vm.title = "Home Page";
};