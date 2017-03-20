(function () {

    angular.module('app').controller('app.views.todo', [
        '$scope',
        function ($scope) {
            var vm = this;

            vm.todos = [
                { text: "1" },
                { text: "2" },
                { text: "3" }
            ];
        }
    ]);
})();