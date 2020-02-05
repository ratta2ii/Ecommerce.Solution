// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

console.log("Yay, I am writing in JavaScript again!!!");

var theParent = document.querySelector(".parent-element");

theParent.addEventListener("click", doSomething, false);
 
function doSomething(event) {
    if (event.target !== event.currentTarget) {
        var clickedItem = event.target.id;
        console.log("Hello " + clickedItem);
        console.log(clickedItem);
    }

}

