
//input phone 

////input phone end

//div animated
//var scroll = window.requestAnimationFrame ||
//    function (callback) { window.setTimeout(callback, 1000 / 60) };

//var elementsToShow = document.querySelectorAll('.show-on-scroll');

//function loop() {

//    elementsToShow.forEach(function (el) {
//        var anime = '';

//        if (el.classList.contains('tr')) {
//            anime = 'tilt-in-tr';
//        }

//        if (el.classList.contains('tl')) {
//            anime = 'tilt-in-tl';
//        }

//        if (el.classList.contains('br')) {
//            anime = 'tilt-in-br';
//        }

//        if (el.classList.contains('bl')) {
//            anime = 'tilt-in-bl';
//        }

//        if (iselInViewport(el)) {
//            el.classList.add(anime);
//        }
//        else {
//            el.classList.remove(anime);
//        }
//    });

//    scroll(loop);
//}

//loop();

//function isElementInViewport(el) {

//    var top = el.offsetTop;
//    var left = el.offsetLeft;
//    var width = el.offsetWidth;
//    var height = el.offsetHeight;

//    while (el.offsetParent) {
//        el = el.offsetParent;
//        top += el.offsetTop;
//        left += el.offsetLeft;
//    }

//    return (
//        top < (window.pageYOffset + window.innerHeight) &&
//        left < (window.pageXOffset + window.innerWidth) &&
//        (top + height) > window.pageYOffset &&
//        (left + width) > window.pageXOffset
//    );
//}
//div animated end

//floated label
$('.form-control').each(function () {
    floatedLabel($(this));
});

$('.form-control').on('input', function () {
    floatedLabel($(this));
});

function floatedLabel(input) {
    var $field = input.closest('.form-group');
    if (input.val()) {
        $field.addClass('input-not-empty');
    } else {
        $field.removeClass('input-not-empty');
    }
}
//floated label end