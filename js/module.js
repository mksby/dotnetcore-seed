angular.module('MainModule',['ui.router']).config(function($stateProvider, $urlRouterProvider){
    $urlRouterProvider.otherwise("/state1");
    $stateProvider
        .state('state1', {
        url: '/state1',
        abstract: true,
        templateUrl: 'about.html',
        controller: 'MainController'
    })
}).controller('MainController', function(){
    console.log(123)
})