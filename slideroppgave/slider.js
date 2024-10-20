console.log("it works");

const left = document.querySelector(".left");
const right = document.querySelector(".right");
const slider = document.querySelector(".slider");
const images = document.querySelectorAll(".image");

let slideNumber = 1;
const length = images.length;

const nextSlide = () => {
    slider.style.transform = `translateX(-${slideNumber * 800}px)`;
    slideNumber++;
};

const getFirstSlide = () => {
    slider.style.transform = `translateX(-0px)`;
    slideNumber = 1;
};

const getLastSlide = () => {
    slider.style.transform = `translateX(-${(length - 1) * 800}px)`;
    slideNumber = length;
};

const prevSlide = () => {
    slider.style.transform = `translateX(-${(slideNumber - 2) * 800}px)`;
    slideNumber--;
};

right.addEventListener("click", () => {
    slideNumber < length ? nextSlide() : getFirstSlide();
    console.log(slideNumber);
});

left.addEventListener("click", () => {
    slideNumber > 1 ? prevSlide() : getLastSlide();
});

//const app = document.getElementById("app");
//updateView();
//function updateView() {
//    app.innerHTML = ``;
//}
