
const translate = document.querySelectorAll(".translate");
const big_title = document.querySelector(".big-title");
const header = document.querySelector("section.header");
const shadow = document.querySelector("section .shadow");
const content = document.querySelector(".paral-content");
const section = document.querySelector("section.under-paral");
const image_container = document.querySelector(".imgContainer");
const opacity = document.querySelectorAll(".paral-opacity");
const border = document.querySelector(".paral-border");

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

    //big_title.style.opacity = - scroll / (header_height / 2) + 1;
    shadow.style.height = `${scroll * 0.5 + 75}px`;

    //content.style.transform = `translateY(${scroll / (section_height + sectionY.top) * 50 - 50}px)`;
    //image_container.style.transform = `translateY(${scroll / (section_height + sectionY.top) * -50 + 50}px)`;

    //border.style.width = `${scroll / (sectionY.top + section_height) * 30}%`;
})
