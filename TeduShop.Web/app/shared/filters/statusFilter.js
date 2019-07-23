(function (app) {
    app.filter('statusFilter', function () {
        return function (intput) {
            if (intput == true) {
                return 'Kích hoạt';
            }
            else
                return 'Khóa';
        }
    })
})(angular.module('tedushop.common'));