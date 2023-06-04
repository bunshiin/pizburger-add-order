let navbar = document.querySelector(".navbar");

document.querySelector("#menu-btn").onclick = () => {
    navbar.classList.toggle("active");
    searchBox.classList.remove("active");
};

window.onscroll = () => {
    navbar.classList.remove("active");
    navbar.classList.remove("active");
}

let searchBox = document.querySelector(".search-form");

document.querySelector("#searchBox").onclick = () => {
    searchBox.classList.toggle("active");
    navbar.classList.remove("active");
};

window.onscroll = () => {
    searchBox.classList.remove("active");
    navbar.classList.remove("active");
}