//Parallax-Scrolling-Effect
const translate = document.querySelectorAll(".translate");
const big_title = document.querySelector(".big-title");
const header = document.querySelector("header");
const shadow = document.querySelector(".shadow");
const content = document.querySelector(".content");
const section = document.querySelector("section");
const image_container = document.querySelector(".imgContainer");
const opacity = document.querySelectorAll(".opacity");
const border = document.querySelector(".border");

let header_height = header.offsetHeight;
let section_height = section.offsetHeight;

window.addEventListener('scroll', () => {
    let scroll = window.pageYOffset;
    let sectionY = section.getBoundingClientRect();

    translate.forEach(element => {
        let speed = element.dataset.speed;
        element.style.transform = `translateY(${scroll * speed}px)`;
    });

    opacity.forEach(element => {
        element.style.opacity = scroll / (sectionY.top + section_height);
    })

    big_title.style.opacity = - scroll / (header_height / 2) + 1;
    shadow.style.height = `${scroll * 0.5 + 300}px`;

    content.style.transform = `translateY(${scroll / (section_height + sectionY.top) * 50 - 50}px)`;
    image_container.style.transform = `translateY(${scroll / (section_height + sectionY.top) * -50 + 50}px)`;

    border.style.width = `${scroll / (sectionY.top + section_height) * 30}%`;
})
//Parallax-Scrolling-Effect end
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

//addToCart animate
$('.add-to-cart').on('click', function () {
    var cart = $('.cart .nav-link');
    var imgtodrag = $(this).closest('.no-gutters').find('img').eq(0);
    if (imgtodrag) {
        var imgclone = imgtodrag.clone()
            .offset({
                top: imgtodrag.offset().top,
                left: imgtodrag.offset().left
            })
            .css({
                'opacity': '0.8',
                'position': 'absolute',
                'height': '150px',
                'width': '150px',
                'z-index': '100'
            })
            .appendTo($('body'))
            .animate({
                'top': cart.offset().top + 10,
                'left': cart.offset().left + 10,
                'width': 75,
                'height': 75
            }, 1000, 'easeInOutExpo');

        setTimeout(function () {
            cart.effect("shake", {
                times: 2
            }, 200);
        }, 1500);

        imgclone.animate({
            'width': 0,
            'height': 0
        }, function () {
            $(this).detach()
        });
    }
});
//addToCart animate end

// ScrollSpy Smooth Animation
$(document).ready(function () {
    $('body').scrollspy({ target: ".navbar", offset: 50 });
    $(".pl-3 a").on('click', function (event) {
        if (this.hash !== "") {
            event.preventDefault();
            var hash = this.hash;
            $('html, body').animate({
                scrollTop: $(hash).offset().top - 120
            }, 800, function () {
                window.location.hash = hash - 120;
            });
        }
    });
});
// ScrollSpy Smooth Animation

