angular
    .module("homeIndex")
    .controller("aboutController", aboutController);

function aboutController() {
    var vm = this;
    vm.title = "About Us";
};