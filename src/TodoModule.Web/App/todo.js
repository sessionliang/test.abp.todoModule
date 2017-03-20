(function () {

    //路由设置
    angular.module('app').config([
        '$stateProvider',
        function ($stateProvider) {
            $stateProvider
                .state('todo', {
                    url: '/todo',
                    templateUrl: '/App/Main/views/test/index.cshtml',
                    menu: 'TodoModule.Tasks'
                });
        }
    ]);


    //自定义的js文件输出
    window.document.write("<script src='/App/Main/views/test/index.js'></script>");

})();