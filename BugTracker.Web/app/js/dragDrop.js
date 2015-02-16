var dragDrop = angular.module('dragDrop', []);
dragDrop.directive('draggable', function () {
    return function (scope, element) {
        var el = element[0];
        el.draggable = true;
        el.addEventListener('dragstart', function (e) {
            e.dataTransfer.effectAllowed = 'move';
            e.dataTransfer.setData('Text', this.id);
            e.dataTransfer.setData('div', this.parentElement.id);
            this.classList.add('drag');
            setEqualHeight();
            return false;
        }, false);
        el.addEventListener('dragend', function (e) {
            this.classList.remove('drag');
            setEqualHeight();
            return false;
        }, false);
    };
});

dragDrop.directive('droppable', ['$http', function ($http) {
    return function (scope, element) {
        var el = element[0];
        el.addEventListener('dragover', function (e) {
            e.dataTransfer.dropEffect = 'move';
            if (e.preventDefault)
                e.preventDefault();
            this.classList.add('over');
            return false;
        }, false);
        el.addEventListener('dragenter', function (e) {
            this.classList.add('over');
            return false;
        }, false);
        el.addEventListener('dragleave', function (e) {
            this.classList.remove('over');
            return false;
        }, false);
        el.addEventListener('drop', function (e) {
            if (e.stopPropagation)
                e.stopPropagation();
            this.classList.remove('over');
            var binId = this.id;
            var item = document.getElementById(e.dataTransfer.getData('Text'));
            var div = document.getElementById(e.dataTransfer.getData('div'));
            this.appendChild(item);
            if (this != div) {
                if (div.id == "Done") {
                    item.children[1].children[1].children[0].classList.remove('done');
                }
                else if (this.id == "Done") {
                    item.children[1].children[1].children[0].classList.add('done');
                }
                var tick = {
                    idTicket: item.id,
                    Status: { "title": binId }
                };
                $http.put('/api/ticket/', tick).success(function (data) {
                });
            }
            return false;
        }, false);
    };
}]);
