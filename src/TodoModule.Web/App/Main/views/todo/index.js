(function () {

    angular.module('app').config([
        '$stateProvider',
        function ($stateProvider) {
            $stateProvider
                .state('todo', {
                    url: '/todo',
                    templateUrl: '/App/Main/views/todo/index.cshtml',
                    menu: 'TodoModule.Tasks'
                });
        }
    ]);

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