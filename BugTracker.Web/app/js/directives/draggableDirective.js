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