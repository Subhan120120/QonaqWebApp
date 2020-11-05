

// Detect request animation frame
var scroll = window.requestAnimationFrame ||
    function (callback) { window.setTimeout(callback, 1000 / 60) };

var elementsToShow = document.querySelectorAll('.show-on-scroll');

function loop() {

    elementsToShow.forEach(function (element) {
        var a = '';

        if (element.classList.contains('tr')) {
            a = 'tilt-in-tr';
        }

        if (element.classList.contains('tl')) {
            a = 'tilt-in-tl';
        }

        if (element.classList.contains('br')) {
            a = 'tilt-in-br';
        }

        if (element.classList.contains('bl')) {
            a = 'tilt-in-bl';
        }

            if (isElementInViewport(element)) {
                element.classList.add(a);
            }
            else {
                element.classList.remove(a);
            }
    });

    scroll(loop);
}

// Call the loop for the first time
loop();



function isElementInViewport(el) {
    var top = el.offsetTop;
    var left = el.offsetLeft;
    var width = el.offsetWidth;
    var height = el.offsetHeight;

    while (el.offsetParent) {
        el = el.offsetParent;
        top += el.offsetTop;
        left += el.offsetLeft;
    }

    return (
        top < (window.pageYOffset + window.innerHeight) &&
        left < (window.pageXOffset + window.innerWidth) &&
        (top + height) > window.pageYOffset &&
        (left + width) > window.pageXOffset
    );
}

// Helper function from: http://stackoverflow.com/a/7557433/274826
//function isElementInViewport(el) {
//    // special bonus for those using jQuery
//    if (typeof jQuery === "function" && el instanceof jQuery) {
//        el = el[0];
//    }
//    var rect = el.getBoundingClientRect();
//    return (
//        (rect.top <= 0
//            && rect.bottom >= 0)
//        ||
//        (rect.bottom >= (window.innerHeight || document.documentElement.clientHeight) &&
//            rect.top <= (window.innerHeight || document.documentElement.clientHeight))
//        ||
//        (rect.top >= 0 &&
//            rect.bottom <= (window.innerHeight || document.documentElement.clientHeight))
//    );
//}
