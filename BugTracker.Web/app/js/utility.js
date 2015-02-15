function setEqualHeight() {
    var columns = $('div.bin');
    var len = 0;
    columns.each(function () {
        currentLen = $(this).children().length;
        if (currentLen > len) {
            len = currentLen;
        }
    }
    );
    columns.height(len * 80 + 'px');
}
