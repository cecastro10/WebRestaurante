
//registra o controller e cria a função para obter os dados do Controlador MVC
app.controller('PratoCtrl', ['$scope',
            '$rootScope',
            '$http',
            'ngTableParams', function ($scope, $rootScope, $http, ngTableParams) {

                $scope.pratos = [];

                $scope.prato = {};

                $scope.pesquisar = function () {
                    $http.post('/Pratos/Search/', { pesquisaPrato: $scope.prato }).then(
                        function (response) {
                            $scope.pratos = response.data;
                            //  $scope.paginacaoPesquisa($scope.pratos);

                        }, function (error) {
                            $scope.pratos = [];
                            // $scope.paginacaoPesquisa($scope.pratos);
                            alert('Erro ao consultar os dados de pratos');
                        });
                }

                //chama o  método IncluirPrato do controlador
                $scope.EditarPrato = function (item) {
                    window.location = '/Pratos/Edit/' + item.ID;
                  
                }
                //chama o  método IncluirPrato do controlador
                $scope.SalvarPrato = function () {
                    $http.post('/Pratos/Edit/', { prato: $scope.prato }).then(
                    function (response) {
                        $scope.pratos = response.data;
                        delete $scope.prato;
                        $scope.voltar();
                    }, function (error) {
                        alert('Erro ao inserir os dados do prato');
                    });
                }

                //chama o  método IncluirPrato do controlador
                $scope.AddPrato = function () {
                    $http.post('/Pratos/Create/', { prato: $scope.prato }).then(
                    function (response) {
                        $scope.pratos = response.data;
                        delete $scope.prato;
                        $scope.voltar();
                    }, function (error) {
                        alert('Erro ao inserir os dados do prato');
                    });
                }

                $scope.voltar = function () {
                    window.location = '/Pratos/';
                }

                //chama o  método ExcluirPrato do controlador
                $scope.DeletaPrato = function (item) {
                    $http.post('/Pratos/DeleteConfirmed/', { id: item.ID }).then(
                  function (response) {
                      $scope.pratos = response.data;
                      delete $scope.prato;
                      $scope.pesquisar();
                  }, function (error) {
                      alert('Erro ao excluir os dados do prato');
                  });
                }

                $scope.index = function () {
                    $scope.pesquisar();
                };

                $scope.restaurantes = [];

                $scope.restaurante = {};

                $scope.listarRestaurantes = function () {
                    $http.post('/Restaurantes/Search/', { pesquisaRestaurante: $scope.restaurante }).then(
                        function (response) {
                            $scope.restaurantes = response.data;
                            //$scope.paginacaoPesquisa($scope.restaurantes);

                        }, function (error) {
                            $scope.restaurantes = [];
                            //  $scope.paginacaoPesquisa($scope.restaurantes);
                            alert('Erro ao consultar os dados de restaurantes');
                        });
                }

                $scope.listarRestaurantes();

                $scope.init = function (prato) {
                    $scope.prato = prato;
                }

            }]);